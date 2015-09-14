//From other class to output 

using System;

public class Hello6
{
    public static void Main()
    {
       Hw newHello = new Hw();
       newHello.print();
    }
}

public class Hw
{
    public void print()
    {
        Console.WriteLine("Hello World! 6");
    }
}
