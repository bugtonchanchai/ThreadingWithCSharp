using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static int MAX_NUMBER = 50;
    static int proceed_number = 1;

    static void Main(string[] args)
    {
        int NUM_THREAD = Environment.ProcessorCount;
        for (int i = 0; i < NUM_THREAD; i++)
        {
            Thread th = new Thread(delegate ()
            {
                int threadId = AppDomain.GetCurrentThreadId();
                while (proceed_number <= MAX_NUMBER)
                {
                    int n = proceed_number++;
                    if (IsPrime(n))
                    {
                        Console.WriteLine("Thread {0} => {1} is prime.", threadId, n);
                    }
                    else
                    {
                        Console.WriteLine("Thread {0} => {1} is not prime.", threadId, n);
                    }
                }
            });
            th.Start();
        }
    }

    private static bool IsPrime(int n)
    {
        for (int i = 2; i < n; i++)
        {
            if (n % i == 0 && i != n) return false;
        }
        return true;
    }
}
