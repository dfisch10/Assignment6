using Assignment_6.activities;
using Assignment_6.workflow;
using Assignment_6.workflowengine;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Assignment_6
{
    [ExcludeFromCodeCoverage]
    class Program
    {
        static void Main(string[] args)
        {
            var workFlowEngine = new WorkFlowEngine();

            var workFlow = new WorkFlow()
                .RegisterActivity(new VideoUploadActivity(1))
                .RegisterActivity(new EmailNotificationActivity(3))
                .RegisterActivity(new ThirdPartyNotificationActivity(2))
                .RegisterActivity(new InitializeDatabaseActivity(4)); 

            workFlowEngine.Run(workFlow);        
        }
    }
}
 