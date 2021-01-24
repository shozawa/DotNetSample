using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Currency(42);
            var b = new Currency(42);
            Console.WriteLine(a.Add(b).Value);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
