using Assignment_6.interfaces;
using System;

namespace Assignment_6.activities
{
    public class ThirdPartyNotificationActivity : IActivity, IComparable
    {
        public int sequence { get; set; }

        public ThirdPartyNotificationActivity(int sequence)
        {
            this.sequence = sequence;
        }

        public void Execute()
        {
            Console.WriteLine("Third party has been notified that video has been processed.....");
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            IActivity otherActivity = obj as IActivity;
            if (otherActivity != null)
                return this.sequence.CompareTo(otherActivity.sequence);
            else
            {
                throw new ArgumentException("Object is not an Activity");
            }
        }
    }
}