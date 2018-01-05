using System;

namespace Workflow
{
    class StatusUpdate : ITask
    {
        public void Run()
        {
            Console.WriteLine("Video status: PROCESSING");
        }
    }
}