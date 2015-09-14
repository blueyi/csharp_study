//delegate

using System;
public class Hello12
{
    delegate void simpleDelegate();
    public void print()
    {
        Console.WriteLine("Hello World! 12");
    }

    public static void Main()
    {
        Hello12 hw = new Hello12();
        simpleDelegate d = new simpleDelegate(hw.print);
        d();
    }
}
