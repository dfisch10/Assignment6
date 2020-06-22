﻿using System;
using System.Collections;
using System.Collections.Generic;
using Assignment_6.activities;
using Assignment_6.interfaces;
using Microsoft.VisualBasic;

namespace Assignment_6.workflow
{
    public class WorkFlow : IWorkFlow
    {
        #region Properties
        /// <summary>
        /// a readonly list of type IActivity that stores the activies registered to be used via the workflow/workflow engine.
        /// </summary>
        private readonly List<IActivity> registeredActivities;
        #endregion

        #region Constructor
        /// <summary>
        /// The Constructor for class WorkFlow, which implements the registerActivities list in order to track the count of the list, 
        /// the ability to add to the list, as well as holding various activity information within the list.
        /// </summary>
        public WorkFlow()
        {
            registeredActivities = new List<IActivity>();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Adds the activity specified in the method parameter to the "registeredActivities" list, 
        /// and then sorts the list after adding to ensure the activity occurs in proper sequence.
        /// </summary>
        /// <param name="activity">The activity being passed into the workflow</param>
        public void RegisterActivity(IActivity activity)
        {
            if(activity == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You have tried to register a null activity, please enter an activity for this instance, and try again.");
                Console.ResetColor();
                return;
            }
                registeredActivities.Add(activity);
                registeredActivities.Sort();
        }

        /// <summary>
        /// Method using the IEnumerable in order to be able to list out the various activities stored in the "registerActivities" list via foreach statement.
        /// </summary>
        /// <returns>Returns the information for each activity contained in the list, in this case that is the console.writeline statements.</returns>
        public IEnumerable<IActivity> ActivitiesList()
        {
            return registeredActivities;
        }

        /// <summary>
        /// Counts the amount of activities currently stored within the registeredActivities list.
        /// </summary>
        /// <returns>returns the int amount of activities stored in the list.</returns>
        public int CountActivities()
        {
            return registeredActivities.Count;
        }
        #endregion
    }
}