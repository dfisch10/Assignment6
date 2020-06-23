using Assignment_6.interfaces;
using Assignment_6.Utilities;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Assignment_6.activities
{
    public class VideoUploadActivity : IActivity, IComparable
    {
        #region Properties
        /// <summary>
        /// The getter and setter for sequence, which allows us to dictate the sequence order that activities should occur in.
        /// </summary>
        public int Sequence { get; set; }
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor for VideoUploadActivity class, which creates an instance of the activity 
        /// and passing in the paramter to label its sequence to be carried out in a workflow.
        /// </summary>
        /// <param name="sequence">The sequence that the activity should be carried out in of type int.</param>
        public VideoUploadActivity(int sequence)
        {
            this.Sequence = sequence;
        }
        #endregion

        #region Methods
        [ExcludeFromCodeCoverage]
        /// <summary>
        /// Method to "execute" the console.writeline message when called.
        /// </summary>
        public void Execute()
        {
            Console.WriteLine("Uploading video to the cloud storage repository.....");
        }

        [ExcludeFromCodeCoverage]
        /// <summary>
        /// Compares two objects, of type IActivity's, sequence number to eachother in order to allow for proper sorting
        /// </summary>
        /// <param name="obj"> The object in this case is an activity of type IActivity</param>
        /// <returns>Returns the proper order for sorting purposes.</returns>
        public int CompareTo(object obj)
        {
            if (obj is null)
            {
                ActivityUtility.ErrorMessage();
            }
            return ActivityUtility.Compare(this, (IActivity)obj);
        }
        #endregion
    }
}