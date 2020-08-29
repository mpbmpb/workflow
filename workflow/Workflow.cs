using System;
using System.Collections.Generic;

namespace workflow
{
    public class Workflow
    {
        private List<IExecutable> _taskList;

        public Workflow()
        {
            _taskList = new List<IExecutable>();
        }

        public void Add(IExecutable task)
        {
            _taskList.Add(task);
        }

        public void Remove(IExecutable task)
        {
            if (!_taskList.Contains(task))
                throw new NullReferenceException("Task is not in taskList");
            _taskList.Remove(task);
        }

        public List<IExecutable> GetTaskList ()
        {
            return _taskList;
        }

        public void LogContents()
        {
            Console.WriteLine("Workflow contents: ");
            Console.WriteLine();
            foreach (var task in _taskList)
            {
                Console.WriteLine(task + ";");
            }
            Console.WriteLine("---------------------------");
            Console.WriteLine($"Total: {_taskList.Count} tasks");
            Console.WriteLine();
        }
    }
}
