using Domain.Base;
using Domain.Enumerator;
using System;

namespace Domain.Model
{
    public class Job : BaseJob
    {
        private void Reset(JobTemplate template)
        {
            this.Status = JobStatus.Ready;
            this.TimeLeft = template.TimeLeft;
            this.Potency = template.Potency;
            this.Template = template;
        }

        public Job(JobTemplate template)
        {
            Reset(template);
        }

        public Job(DigitalMicroWave microWave)
        {
            JobTemplate template = new JobTemplate(microWave.TimeLeft, microWave.Potency);

            Reset(template);
        }

        public JobStatus Status { get; private set; }
        public JobTemplate Template { get; private set; }

        public void OverridePotency(Potency potency)
        {
            this.Potency = Potency;
        }

        public void OverrideTimeleft(Int16 timeleft)
        {
            this.TimeLeft = timeleft;
        }

        /// <summary>
        /// Sum of dot, prints a dot x potency for each second passed
        /// </summary>
        public String Dotz { get; private set; }

        #region StateControl

        public void Pause()
        {
            this.Status = JobStatus.Paused;
        }

        public void Resume()
        {
            this.Status = JobStatus.Running;
        }

        public void Start()
        {
            this.Status = JobStatus.Running;
            Dotz = String.Empty.PadLeft((Int32)this.Potency, this.Template.Dot);
        }

        public void Tick()
        {
            switch (this.Status)
            {
                case JobStatus.Running:
                    if (TimeLeft <= 0)
                    {
                        this.Status = JobStatus.Done;
                    }
                    else
                    {
                        this.TimeLeft--;
                    }
                    break;
                default: break;
            }
        }

        #endregion StateControl
    }
}