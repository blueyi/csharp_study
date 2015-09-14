// Attribute
#define DEBUGGING
using System;
using System.Diagnostics;

public class Hello13 : Attribute
{
    [Conditional("DEBUGGING")]
    public void print()
    {
        Console.WriteLine("Hello World! 13");
    }
    public static void Main()
    {
        Hello13 hw = new Hello13();
        hw.print();
    }
}
