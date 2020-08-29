using System;
using System.Threading;

namespace workflow
{
    public class VirtualAudioSystem : IExecutable
    {
        public void Execute()
        {
            Console.Write("Starting virtual audio system");
            Thread.Sleep(800);

            for (int i = 0; i < 3; i++)
            {
                Console.Write(".");
                Thread.Sleep(400);
            }
            Console.WriteLine();
            Console.WriteLine("Virtual audio system is running.");
            Console.WriteLine();
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}()";
        }
    }
}
