using HelloLibrary;
using System;

namespace HelloApplication
{
    public class HelloApp
    {
        public static void Main()
        {
            HelloMessage hm = new HelloMessage();
            Console.WriteLine(hm.Message);
        }
    }
}
