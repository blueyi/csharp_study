//using instance function

using System;

public class Hello5
{
    public void print()
    {
        Console.WriteLine("Hello World! 5");
    }

    public static void Main()
    {
        Hello5 hw = new Hello5();
        hw.print();
    }
}
