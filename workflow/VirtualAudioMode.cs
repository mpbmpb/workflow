using System;
using System.Threading;

namespace workflow
{
    public class VirtualAudioMode : IExecutable
    {
        private readonly string _mode;

        public VirtualAudioMode(string mode)
        {
            if (mode == null || mode == "")
                throw new NullReferenceException("Virtual audio mode must be defined");
            _mode = mode;
        }

        public void Execute()
        {
            Console.Write($"Setting virtual audio system to {_mode} mode");
            Thread.Sleep(800);

            for (int i = 0; i < 3; i++)
            {
                Console.Write(".");
                Thread.Sleep(400);
            }
            Console.WriteLine();
            Console.WriteLine($"Virtual audio system succesfully set to {_mode} mode. ");
            Console.WriteLine();
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}({_mode})";
        }
    }
}
