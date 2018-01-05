using System;

namespace Workflow
{
    class VideoEncodeWebService : ITask
    {
        public void Run()
        {
            Console.WriteLine("Encoding video started...");
        }
    }
}