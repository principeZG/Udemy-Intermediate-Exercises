namespace Workflow
{
    public class WorkflowEngine
    {

        public void Run(IWorkFlow workFlow)
        {

            foreach (ITask task in workFlow.GetTasks())
            {
                task.Run(); 
            }
        }
    }
}