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
    }
}