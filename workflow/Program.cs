namespace workflow
{
    class Program
    {
        static void Main(string[] args)
        {
            var work = new Workflow();
            work.Add(new SplineReticulator("curvilinear"));
            work.Add(new VirtualAudioMode("silent"));
            work.Add(new VirtualAudioSystem());
            var task = new VirtualAudioMode("invisible");
            work.Add(task);

            work.LogContents();
            work.Remove(task);

            WorkflowEngine.Run(work);
            work.LogContents();
        }
    }
}
