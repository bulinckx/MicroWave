using Domain.Base;
using Domain.Enumerator;
using System;

namespace Domain.Model
{
    public class JobTemplate : BaseJob
    {
        public JobTemplate(Int16 timeLeft, Potency potency)
        {
            this.Id = Guid.NewGuid();
            this.TimeLeft = timeLeft;
            this.Potency = potency;
        }

        /// <summary>
        /// To be called only by JobTemplateParameterLess
        /// </summary>
        public JobTemplate(Int16 timeLeft, Potency potency, Guid id)
        {
            this.Id = id;
            this.TimeLeft = timeLeft;
            this.Potency = potency;
        }

        public String Name { get; set; } = "New Job";
        public MealKind? MealKind { get; set; }

        public Char Dot { get; set; } = '.';

        public String Instructions { get; set; }
        public Boolean CanDelete { get; set; } = true;
        public Boolean Default { get; set; } = false;

        public Guid Id { get; private set; }
    }

    /// <summary>
    /// This class maps to JobTemplate
    /// it exists only to bypass a json deserialization limitation
    /// on parameterfull constructors and private setters
    /// </summary>
    public class JobTemplateParameterLess
    {
        public Potency Potency { get; set; }
        public Int16 TimeLeft { get; set; }
        public String Name { get; set; }
        public MealKind? MealKind { get; set; }
        public Char Dot { get; set; }
        public String Instructions { get; set; }
        public Boolean CanDelete { get; set; }
        public Boolean Default { get; set; }
        public Guid Id { get; set; }

        public JobTemplate Get()
        {
            return new JobTemplate(this.TimeLeft, this.Potency, this.Id)
            {
                CanDelete = CanDelete,
                Default = Default,
                Name = Name,
                Instructions = Instructions,
                Dot = Dot
            };
        }
    }
}