using System;
using System.Threading;

class Program
{
    static void Main()
    {
        // Synchronous
        DemoThread("Thread 1");
        DemoThread("Thread 2");
        DemoThread("Thread 3");

        // Asynchronous 

        //Thread async_task_1 = new Thread(() =>
        //{
        //    DemoThread("Thread 1");
        //});
        //async_task_1.Start();

        //Thread async_task_2 = new Thread(() =>
        //{
        //    DemoThread("Thread 2");
        //});
        //async_task_2.Start();

        //Thread async_task_3 = new Thread(() =>
        //{
        //    DemoThread("Thread 3");
        //});
        //async_task_3.Start();
    }

    static void DemoThread(string ThreadIndex)
    {
        for(int i = 0; i < 5; i++)
        {
            Thread.Sleep(TimeSpan.FromSeconds(1));
            Console.WriteLine(ThreadIndex + "-" + i);
        }
    }
}