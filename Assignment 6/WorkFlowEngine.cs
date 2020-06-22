using System;
using Assignment_6.workflow;
using Assignment_6.workflowengine;
using Assignment_6.interfaces;
using Assignment_6.activities;
using System.Threading;

namespace Assignment_6.workflowengine
{
    public class WorkFlowEngine : IWorkFlowEngine
    {
        #region Methods
        /// <summary>
        /// Runs throw the workflow and executes the various activities contained in a presorted list 
        /// using the execute logic/commands/console.writeline for each activity in the list.
        /// </summary>
        /// <param name="workFlow">The workflow containing a list of activities, along with theire specified sequences, to be ran by the workflowengine</param>
        public void Run(IWorkFlow workFlow)
        {       
            foreach (var activity in workFlow.ActivitiesList())
            {
                int count = 1;

                while(activity.sequence >= count)
                {
                    if (activity.sequence == count)
                    {
                        activity.Execute();
                    }
                    count++;
                }              
            }
        }
        #endregion
    }
}