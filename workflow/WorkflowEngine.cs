namespace workflow
{
    public class WorkflowEngine
    {
        public static void Run(Workflow flow)
        {
            foreach (var task in flow.GetTaskList())
            {
                task.Execute();
            }
        }
    }
}
