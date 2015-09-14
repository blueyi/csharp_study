// Interface

using System;

interface IHello
{
   void print();
}
public class Hello14 : IHello
{
    public void print()
    {
        Console.WriteLine("Hello World! 14");
    }

    public static void Main()
    {
        Hello14 hw = new Hello14();
        hw.print();
    }
}

