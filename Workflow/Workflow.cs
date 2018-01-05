using System.Collections.Generic;

namespace Workflow
{
    public class Workflow : IWorkFlow
    {
        private readonly IList<ITask> _tasks;

        public Workflow()
        {
            _tasks = new List<ITask>();
        }

        public void AddTask(ITask task)
        {
            _tasks.Add(task);
        }

        public void RemoveTask(ITask task)
        {
            _tasks.Remove(task);
        }

        public IEnumerable<ITask> GetTasks()
        {
            return _tasks;
        }
    }
}