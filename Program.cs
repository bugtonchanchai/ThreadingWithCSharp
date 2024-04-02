using System;
using System.Threading;

class Program
{
    public static void Main(string[] args)
    {
        DateTime startTime = DateTime.Now;


        Thread thread = new Thread(new ThreadStart(ThreadRun));
        thread.Start();

        MainRun();
        // ThreadRun();

        DateTime endTime = DateTime.Now;
        TimeSpan totalTime = endTime - startTime;

        Console.WriteLine("Total time used: " + totalTime);
    }

    private static void MainRun()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("[1] MainRun : " + i);
            Thread.Sleep(1500);
        }

        Console.WriteLine("[1] MainRun finished.");
    }

    private static void ThreadRun()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("[2] ThreadRun : " + i);
            Thread.Sleep(1000);
        }

        Console.WriteLine("[2] ThreadRun finished.");
    }
}
