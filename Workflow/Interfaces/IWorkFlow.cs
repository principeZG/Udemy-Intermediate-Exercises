using System.Collections.Generic;

namespace Workflow
{
    public interface IWorkFlow
    {
        void AddTask(ITask task);
        void RemoveTask(ITask task);
        IEnumerable<ITask> GetTasks();
    }
}