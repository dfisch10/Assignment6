using System;
using System.Collections;
using System.Collections.Generic;
using Assignment_6.activities;
using Assignment_6.interfaces;
using Microsoft.VisualBasic;

namespace Assignment_6.workflow
{
    public class WorkFlow : IWorkFlow
    {
        private readonly List<IActivity> registeredActivities;

        public WorkFlow()
        {
            registeredActivities = new List<IActivity>();
        }

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

        public IEnumerable<IActivity> ActivitiesList()
        {
            return registeredActivities;
        }

        public int CountActivities()
        {
            return registeredActivities.Count;
        }
    }
}