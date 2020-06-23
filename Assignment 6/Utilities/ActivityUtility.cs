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
        /// <summary>
        /// Takes two specified IActivity type activities, and compares them against eachother based off of their sequence values in order to sort them.
        /// </summary>
        /// <param name="activity">First activity to be compared against</param>
        /// <param name="activity2">Second activity to be compared against</param>
        /// <returns></returns>
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

        /// <summary>
        /// Method that changes the foreground color to red and returns an error message notifying the person they have tried to enter a null activity,
        /// it then resets the foreground color to default.
        /// </summary>
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
