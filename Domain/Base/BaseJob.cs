using Domain.Enumerator;
using System;

namespace Domain.Base
{
    public abstract class BaseJob
    {
        public Potency Potency { get; protected set; }

        /// <summary>
        /// Time left to cook, in seconds
        /// </summary>
        public Int16 TimeLeft { get; protected set; }
    }
}