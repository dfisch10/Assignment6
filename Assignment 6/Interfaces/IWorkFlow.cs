using System.Collections;
using System.Collections.Generic;
using Assignment_6.activities;

namespace Assignment_6.interfaces
{
    public interface IWorkFlow
    {
        /// <summary>
        /// Getter and Setter property for the Activities list of type IActivity which keeps track of all the activities that are registered
        /// </summary>
        public List<IActivity> Activities { get; set; }

        /// <summary>
        /// Adds the activity specified in the method parameter of type IActivity to the "registeredActivities" list, 
        /// and then sorts the list after adding to ensure the activity occurs in proper sequence.
        /// </summary>
        /// <param name="activity">The activity being passed into the workflow</param>
        void RegisterActivity(IActivity activity)
        {
        }

       /* /// <summary>
        /// Method using the IEnumerable in order to be able to list out the various activities stored in a list via foreach statement.
        /// </summary>
        /// <returns>Returns the information for each activity contained in the list using a foreach statement.</returns>
        IEnumerable<IActivity> ActivitiesList();*/
    }
}