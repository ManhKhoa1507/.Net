using System;
using Acme.Collections;

class Example
{
    public static void Main()
    {
        var s = new Stack<int>();
        s.Push(1);
        s.Push(10);
        s.Push(100);

        Console.WriteLine(s.Pop());
        Console.WriteLine(s.Pop());
        Console.WriteLine(s.Pop());

        while(s.Is_Empty() == false)
        {
            Console.WriteLine(s.Pop());
        }
    }
}