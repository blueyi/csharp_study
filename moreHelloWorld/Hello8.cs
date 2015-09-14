//static constructor function

using System;

public class Hello8
{
    private static string strHelloWorld;
    static Hello8()
    {
        strHelloWorld = "Hello World! 8";
    }
    private void print()
    {
        Console.WriteLine(strHelloWorld);
    }

    public static void Main()
    {
        Hello8 hw = new Hello8();
        hw.print();
    }
}
