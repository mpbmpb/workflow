using System;
using System.Threading;

namespace workflow
{
    public class SplineReticulator : IExecutable
    {
        private readonly string _coordinateType;

        public SplineReticulator(string coordinateType)
        {
            if (coordinateType == null || coordinateType == "")
                throw new NullReferenceException("coordinateType must be " +
                    "defined for splines to be reticulated.");

            _coordinateType = coordinateType;
        }

        public void Execute()
        {
            Console.Write($"Starting spline reticulation using " +
                $"{_coordinateType} covariant basis");
            Thread.Sleep(800);

            for (int i = 0; i < 3; i++)
            {
                Console.Write(".");
                Thread.Sleep(400);
            }
            Console.WriteLine();
            Console.WriteLine("Splines were succesfully reticulated");
            Console.WriteLine();
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}({_coordinateType})";
        }
    }
}
