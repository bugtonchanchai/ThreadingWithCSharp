using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        int numThreads = Environment.ProcessorCount; // Get the number of logical processors
        Console.WriteLine("Number of logical processors: " + numThreads);

        // Create and start multiple threads
        for (int i = 0; i < numThreads; i++)
        {
            Thread thread = new Thread(PerformCalculations);
            thread.Start();
        }

        Console.WriteLine("Press any key to stop...");
        Console.ReadKey();
    }

    static void PerformCalculations()
    {
        while (true)
        {
            // This loop performs CPU-bound calculations
            double result = 0;
            for (int i = 0; i < 1000000; i++)
            {
                result += Math.Sqrt(i);
            }
        }
    }
}
