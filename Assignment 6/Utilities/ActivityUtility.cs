using Assignment_6.interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Assignment_6.Utilities
{
    public static class ActivityUtility
    {
        #region Methods
        public static int Compare(IActivity activity, IActivity activity2)
        {
            if (activity == null && activity2 != null) return -1;
            if (activity == null && activity2 == null) return 0;
            if (activity != null && activity2 == null) return 1;
            if (activity != null && activity2 != null)
                return activity.Sequence.CompareTo(activity2.Sequence);
            else
            {
                throw new ArgumentException("Object is not an Activity");
            }
        }

        [ExcludeFromCodeCoverage]
        public static void ErrorMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You have tried to register a null activity, please enter an activity for this instance, and try again.");
            Console.ResetColor();
        }
        #endregion
    }
}
