using Domain.Base;
using Domain.Enumerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Domain.Model
{
    public class JobRunningEventArgs : EventArgs
    {
        public int Threshold { get; set; }
        public DateTime TimeReached { get; set; }
    }

    public class DigitalMicroWave : BaseJob
    {
        protected virtual void OnJobRunningEventFired(JobRunningEventArgs e)
        {
            EventHandler<JobRunningEventArgs> handler = JobRunningEvent;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public event EventHandler<JobRunningEventArgs> JobRunningEvent;

        private void TriggerEvent()
        {
            JobRunningEventArgs args = new JobRunningEventArgs();
            args.Threshold = 33;// threshold;
            args.TimeReached = DateTime.Now;
            OnJobRunningEventFired(args);
        }

        public DigitalMicroWave(IList<JobTemplate> templates, Int16 defaultTime, Potency defaultPotency)
        {
            this.Status = MicroWaveStatus.JobLess;
            this.CurrentJob = null;
            this._templateList = templates;
            this.Potency = defaultPotency;
            this.TimeLeft = defaultTime;
        }

        public MicroWaveStatus Status { get; private set; }
        public Job CurrentJob { get; private set; }
        private IList<JobTemplate> _templateList;

        public void OverridePotency(Potency potency)
        {
            this.Potency = Potency;
            if (this.CurrentJob != null)
                this.CurrentJob.OverridePotency(potency);
        }

        public void OverrideTimeleft(Int16 timeleft)
        {
            this.TimeLeft = timeleft;
            if (this.CurrentJob != null)
                this.CurrentJob.OverrideTimeleft(timeleft);
        }

        #region Templates

        public IList<JobTemplate> GetTemplateByNameKind(String name, MealKind? kind)
        {
            if (kind == null)
                return this._templateList.Where(t => t.Name.Contains(name)).ToList();
            else
                return this._templateList.Where(t => t.Name.Contains(name) && t.MealKind == kind).ToList();
        }

        public void SaveTemplate(JobTemplate newTemplate)
        {
            var oldVersion = this._templateList.FirstOrDefault(t => t.Id.Equals(newTemplate.Id));
            if (oldVersion == null)
                this._templateList.Add(newTemplate);
            else
                oldVersion = newTemplate;
        }

        public void DeleteTemplate(JobTemplate template)
        {
            this._templateList.Remove(template);
        }

        #endregion Templates

        #region Job Status

        public void SetJobTemplate(JobTemplate template)
        {
            this.CurrentJob = new Job(template);
            this.Status = MicroWaveStatus.Ready;
        }

        public void ResetJob()
        {
            if (this.CurrentJob == null)
            {
                this.CurrentJob = new Job(this);
            }
        }

        public void StartJob()
        {
            ResetJob();
            this.Status = MicroWaveStatus.Running;
            this.CurrentJob.Start();
        }

        public void PauseJob()
        {
            this.Status = MicroWaveStatus.DoorOpen;
            this.CurrentJob.Pause();
        }

        public void ResumeJob()
        {
            this.Status = MicroWaveStatus.Running;
            this.CurrentJob.Resume();
        }

        public void CancelJob()
        {
            this.Status = MicroWaveStatus.JobLess;
            this.CurrentJob = null;
        }

        public void Tick(Object stateInfo)
        {
            AutoResetEvent autoEvent = (AutoResetEvent)stateInfo;

            if (this.Status == MicroWaveStatus.Running)
            {
                this.CurrentJob.Tick();

                if (this.CurrentJob.Status == JobStatus.Done)
                {
                    this.Status = MicroWaveStatus.Ready;
                    this.CurrentJob = null;
                    autoEvent.Set();
                }

                TriggerEvent();
            }
        }

        #endregion Job Status
    }
}