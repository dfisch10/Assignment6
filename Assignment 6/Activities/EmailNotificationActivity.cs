using Assignment_6.interfaces;
using System;
using System.Net.Http;

namespace Assignment_6.activities
{
    public class EmailNotificationActivity : IActivity, IComparable
    {
        public int sequence { get; set; }

        public EmailNotificationActivity(int sequence)
        {
            this.sequence = sequence;
        }
        public void Execute()
        {
            Console.WriteLine("Sending email to confirm processing of video.....");
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