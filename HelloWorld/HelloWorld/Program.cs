using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0} {1}", UInt64.MinValue, UInt64.MaxValue);
            Console.WriteLine(Convert.ToBoolean("true"));
            Console.WriteLine(Convert.ToBoolean("false"));
            Console.WriteLine(Convert.ToBoolean("yes"));
        }
    }
}
