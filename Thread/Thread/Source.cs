using System.Threading;
using System.IO;
using System;

class Program
{
    static void Main()
    {
        // Create the Thread 
        Thread t = new Thread ( new ThreadStart(MethodA));
        t.Start();
        
        MethodB();
        Console.ReadKey();
    }

    static void MethodA()
    {
        for (int i = 0; i < 100; i++)
            Console.Write("0");
    }
    static void MethodB()
    {
        for (int i = 0; i < 100; i++)
            Console.Write("1");
    }
}