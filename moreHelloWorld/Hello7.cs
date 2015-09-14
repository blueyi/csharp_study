// Inherit

using System;

public abstract class Hello7Base
{
    public abstract void print();
}

public class Hello7 : Hello7Base
{
    public override void print()
    {
        Console.WriteLine("Hello World! 7");
    }
}

public class TempHello
{
    public static void Main()
    {
        Hello7 hw = new Hello7();
        hw.print();
    }
}

