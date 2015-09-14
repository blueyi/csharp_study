//Unsafe Hello world

using System;

public class Hello16
{
    unsafe public void print(char[] arr)
    {
        fixed(char *parr = arr)
        {
            for (int i=0; i<arr.Length; ++i) {
                Console.Write(*(parr + i));
            }
        }
    }

    public static void Main()
    {
        Hello16 hw = new Hello16();
        char[] str = new char[] {'H','l', 'l', 'o', ' ', 'W', 'o', 'r', 'l', 'd', '!'};
        hw.print(str);
    }
}
