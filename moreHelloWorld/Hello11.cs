//use property
using System;

public class Hello11
{
    public string Message {
        get {
            return "Hello World! 11";
        }
    }

    public static void Main()
    {
        Hello11 hw = new Hello11();
        Console.WriteLine(hw.Message);
    }
}
