using System;
using Queue;

class Example
{
    public static void Main()
    {
        var q = new Queue<int>();
        q.Push(1);
        q.Push(10);
        q.Push(100);

        while(q.Is_Empty() != true)
        {
            Console.WriteLine(q.Pop());
        }
    }
}