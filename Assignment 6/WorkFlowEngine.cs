using System;
using Assignment_6.workflow;
using Assignment_6.workflowengine;
using Assignment_6.interfaces;
using Assignment_6.activities;
using System.Threading;
using System.Linq;

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
            if(workFlow is null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You have tried to register a null workflow, please enter an activity for this instance, and try again.");
                Console.ResetColor();
                return;
            }

            var orderedList = workFlow.Activities.OrderBy(m => m.Sequence);
 
            for (int index = 0; index < orderedList?.Count(); index++)
            {
                var activity = orderedList?.ElementAt(index);
                activity?.Execute();
            }
        }
        #endregion
    }
}