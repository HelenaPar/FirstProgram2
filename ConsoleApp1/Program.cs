using System;

namespace ConsoleApp1
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hi " + name + "!");
            Console.ReadKey();
        }
    }
}
