using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            var currentDate = DateTime.Now;
            Console.WriteLine($"{Environment.NewLine}Hello, {name}, at {currentDate:t} on {currentDate:d}!");
            Console.Write($"{Environment.NewLine}Press any key to exit {name}...");
            Console.ReadKey(true);
        }
    }
}