using System;

namespace Workflow
{
    class UploadVideo : ITask
    {
        public void Run()
        {
            Console.WriteLine("Video upload started...");
        }
    }
}