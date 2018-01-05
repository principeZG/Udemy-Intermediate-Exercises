using System;

namespace Workflow
{
    internal class SendMail : ITask
    {
        public void Run()
        {
            Console.WriteLine("Email notification sent...");
        }
    }
}