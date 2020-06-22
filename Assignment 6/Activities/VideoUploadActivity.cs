using Assignment_6.interfaces;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Assignment_6.activities
{
    public class VideoUploadActivity : IActivity, IComparable
    {
        public int sequence { get; set; }

        public VideoUploadActivity(int sequence)
        {
            this.sequence = sequence;
        }

        [ExcludeFromCodeCoverage]
        public void Execute()
        {
            Console.WriteLine("Uploading video to the cloud storage repository.....");
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