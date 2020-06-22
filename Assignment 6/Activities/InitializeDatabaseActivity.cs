using Assignment_6.interfaces;
using System;

namespace Assignment_6.activities
{
    public class InitializeDatabaseActivity : IActivity, IComparable
    {
        public int sequence { get; set; }

        public InitializeDatabaseActivity(int sequence)
        {
            this.sequence = sequence;
        }
        public void Execute()
        {
            Console.WriteLine("Video status has changed to PROCESSING in the database.....");
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