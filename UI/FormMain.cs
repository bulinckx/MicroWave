using Domain.Enumerator;
using Domain.Interface;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Media;
using System.Windows.Forms;

namespace UI
{
    public partial class FormMain : Form
    {
        private readonly IDigitalMicroWaveService _service;
        private Boolean _timerReadOnly = true;

        /// <summary>
        /// Handles events comming from the mirowave running job
        /// </summary>
        /// <param name="sender">Microwave</param>
        /// <param name="e">arguments</param>
        static void JobRunningEventHandler(Object sender, JobRunningEventArgs e)
        {
            DigitalMicroWave microwave = (DigitalMicroWave)sender;
            FormMain mainform = (FormMain)Application.OpenForms[0];

            switch (microwave.Status)
            {
                case MicroWaveStatus.Ready:
                    mainform.InvokeAnywhere(c => MessageBox.Show(c, "AQUECIDA")); // passing form as owner so MessageBox behave as modal
                    mainform.InvokeAnywhere(c => c.SetWatch(microwave.TimeLeft));
                    mainform.InvokeAnywhere(c => c.btnStart.Text = "START");
                    break;
                case MicroWaveStatus.Running:
                    mainform.InvokeAnywhere(c => c.txtInputString.Text = c.txtInputString.Text + microwave.CurrentJob.Dotz);

                    if (microwave.CurrentJob != null)
                    {
                        mainform.InvokeAnywhere(c => c._timerReadOnly = false);
                        mainform.InvokeAnywhere(c => c.SetWatch(microwave.CurrentJob.TimeLeft));
                        mainform.InvokeAnywhere(c => c._timerReadOnly = true);
                    }
                    break;
                case MicroWaveStatus.DoorOpen: break;
                case MicroWaveStatus.JobLess: break;
            }
        }

        public FormMain(IDigitalMicroWaveService service)
        {
            _service = service;
            var microwave = _service.Initialize();

            microwave.JobRunningEvent += JobRunningEventHandler;
            InitializeComponent();

            SetDefaultValues(microwave);
            SetTemplatesDataSource(String.Empty, null);
            SetToolTip();
        }

        private void SetToolTip()
        {
            ToolTip tt = new ToolTip();
            tt.IsBalloon = true;
            tt.SetToolTip(btnStartTemplate, "Click to Start form a Template.");
            tt.SetToolTip(btnStart, "Click to Start/Pause.");
            tt.SetToolTip(btnAddTemplate, "Add a template using the actual parameters for potency and time left, also uses the search string as name and the output string as instructions.");
            tt.SetToolTip(lbxTemplate, "Double click to serialize template to InputString without starting a job.");
            tt.SetToolTip(btnCancel, "Cancel any current job and resets microwave to default values.");
            tt.SetToolTip(btnSearch, "Fetches all templates, pre made or not matches selected kind of meal and contains the search string, a empty string returns all.");
        }

        public void SetWatch(Int16 seconds)
        {
            dtpTimer.Value = dtpTimer.MinDate.AddSeconds(seconds);
        }

        private void SetDefaultValues(DigitalMicroWave microwave)
        {
            txtPotency.Value = (Decimal)microwave.Potency;
            dtpTimer.MinDate = new DateTime(1753, 1, 1);
            dtpTimer.MaxDate = new DateTime(1753, 1, 1).AddSeconds(120);
            SetWatch(microwave.TimeLeft);
        }

        private void SetTemplatesDataSource(String name, MealKind? kind)
        {
            IList<JobTemplate> ds = _service.GetTemplateByNameKind(name, kind);

            lbxTemplate.ValueMember = "Name";
            lbxTemplate.DataSource = ds;
        }

        /// <summary>
        /// Generic Wrap to handle exceptions in a call
        /// </summary>
        /// <param name="func">Any method returns T</param>
        private T Wrap<T>(Func<T> func)
        {
            try
            {
                return func();
            }
            catch (Exception ex)
            {
                SystemSounds.Hand.Play();
                txtOutput.Text = ex.Message;
                btnStart.Text = "START";
                return default(T);
            }
        }

        /// <summary>
        /// Generic Wrap to handle exceptions in a call
        /// </summary>
        /// <param name="func">Any method returns void</param>
        private void WrapVoid(Action func)
        {
            try
            {
                func();
            }
            catch (Exception ex)
            {
                SystemSounds.Hand.Play();
                txtOutput.Text = ex.Message;
                btnStart.Text = "START";
                var job = Wrap(() => _service.GetMicroWave().CurrentJob);
                if (job != null)
                    txtPotency.Value = (Decimal)job.Potency;
            }
        }

        private void btnStartTemplate_Click(object sender, System.EventArgs e)
        {
            if (_service.GetStatus() == MicroWaveStatus.Ready || _service.GetStatus() == MicroWaveStatus.JobLess)
            {
                var template = (JobTemplate)lbxTemplate.SelectedItem;

                if (template == null)
                {
                    txtOutput.Text = "No template selected";
                }
                else
                {
                    _service.SetJobTemplate(template);

                    txtPotency.Value = (Decimal)template.Potency;
                    SetWatch(template.TimeLeft);

                    txtInputString.Text = _service.SerializeCurrentJobTemplateToJson();
                    PauseStart();
                }
            }
            else txtOutput.Text = "Microwave is already running a job";
        }

        private void PauseStart()
        {
            switch (_service.GetStatus())
            {
                case MicroWaveStatus.Ready:
                case MicroWaveStatus.JobLess:
                    btnStart.Text = "PAUSE";
                    WrapVoid(() => _service.Start(txtInputString.Text));
                    break;
                case MicroWaveStatus.DoorOpen:
                    btnStart.Text = "PAUSE";
                    WrapVoid(() => _service.Resume());
                    break;
                case MicroWaveStatus.Running:
                    WrapVoid(() => _service.Pause());
                    btnStart.Text = "START";
                    break;
                default: break;
            }
        }

        private void btnStart_Click(object sender, System.EventArgs e)
        {
            PauseStart();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            txtInputString.Text = Wrap(() => _service.Cancel());
            SetDefaultValues(Wrap(() => _service.GetMicroWave()));
            btnStart.Text = "START";
        }

        private void btnTranslate_Click(object sender, System.EventArgs e)
        {
            txtInputString.Text = _service.SerializeCurrentJobTemplateToJson();
        }

        private void btnAddTemplate_Click(object sender, System.EventArgs e)
        {
            var microwave = Wrap(() => _service.GetMicroWave());
            Int16 timeleft = microwave.TimeLeft;
            Potency potency = microwave.Potency;

            if (microwave.CurrentJob != null)
            {
                timeleft = microwave.CurrentJob.Template.TimeLeft;
                potency = microwave.CurrentJob.Template.Potency;
            }

            var newJobTemplate = new JobTemplate(timeleft, potency)
            {
                CanDelete = true,
                Default = false,
                Instructions = txtOutput.Text,
                Name = txtSearchTemplate.Text,
                MealKind = GetSelectedMealKind(),
                Dot = txtSearchTemplate.Text[0]
            };

            var ds = Wrap(() => _service.SaveTemplate(newJobTemplate));
            if (ds != null)
            {
                txtSearchTemplate.Text = String.Empty;
                lbxTemplate.DataSource = ds;
            }
        }

        private void deleteTemplate_Click(object sender, System.EventArgs e)
        {
            var template = (JobTemplate)lbxTemplate.SelectedItem;
            if (template != null)
            {
                var ds = Wrap(() => _service.DeleteTemplate(template, GetSelectedMealKind()));

                if (ds != null)
                    lbxTemplate.DataSource = ds;
            }
        }

        private MealKind? GetSelectedMealKind()
        {
            if (rdbtnMeat.Checked) return MealKind.Meat;
            else
            if (rdbChicken.Checked) return MealKind.Chicken;
            else
            if (rdbCheese.Checked) return MealKind.Cheese;
            else
                return null;
        }

        private void btnSearch_Click(object sender, System.EventArgs e)
        {
            SetTemplatesDataSource(txtSearchTemplate.Text, GetSelectedMealKind());
        }

        private void txtPotency_ValueChanged(object sender, EventArgs e)
        {
            WrapVoid(() => _service.ResetPotency(txtPotency.Value));
        }

        private void dtpTimer_ValueChanged(object sender, EventArgs e)
        {
            if (_timerReadOnly)
                WrapVoid(() => _service.ResetTimeleft(dtpTimer.Value));
        }

        private void lbxTemplate_DoubleClick(object sender, EventArgs e)
        {
            if (_service.GetStatus() == MicroWaveStatus.Ready || _service.GetStatus() == MicroWaveStatus.JobLess)
            {
                var template = (JobTemplate)lbxTemplate.SelectedItem;

                if (template == null)
                {
                    txtOutput.Text = "No template selected";
                }
                else
                {
                    _service.SetJobTemplate(template);

                    txtPotency.Value = (Decimal)template.Potency;
                    SetWatch(template.TimeLeft);

                    txtInputString.Text = _service.SerializeCurrentJobTemplateToJson();
                }
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            WrapVoid(() => _service.PersistTemplates());
        }
    }
}