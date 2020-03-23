using System;
using System.ComponentModel;

namespace UI
{
    public static class ISynchronizeInvokeExtensions
    {
        /// <summary>
        /// Invoke a UI component from any thread (if it implements ISynchronizeInvoke)
        /// </summary>
        /// <typeparam name="T">form type</typeparam>
        /// <param name="this">form/component parent</param>
        /// <param name="action">Lambda, does stuff in the component</param>
        public static void InvokeAnywhere<T>(this T @this, Action<T> action) where T : ISynchronizeInvoke
        {
            if (@this.InvokeRequired)
            {
                @this.Invoke(action, new object[] { @this });
            }
            else
            {
                action(@this);
            }
        }
    }
}