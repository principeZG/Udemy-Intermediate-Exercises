using System;

namespace Workflow
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflow = new Workflow();
            var workflowEngine = new WorkflowEngine();

            workflow.AddTask(new UploadVideo());
            workflow.AddTask(new VideoEncodeWebService());
            workflow.AddTask(new StatusUpdate());
            workflow.AddTask(new SendMail());

            workflowEngine.Run(workflow);

        }
    }
}
