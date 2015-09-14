//Exception Heandling

using System;

public class Hello9
{
    public static void Main(string[] args)
    {
        try {
            Console.WriteLine(args[0]);
        }
        catch(IndexOutOfRangeException e) {
            Console.WriteLine("----{0}---", e.ToString());
        }
    }
}
