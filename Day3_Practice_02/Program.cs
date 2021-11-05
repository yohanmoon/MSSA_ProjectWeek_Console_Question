using System;

namespace Practice_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //get first and last digit of user input
            Console.WriteLine("Enter a number: ");
            var input = Console.ReadLine();
            Console.WriteLine("first digit is    "+input[0]);
            int last = input.Length-1;
            Console.WriteLine("Last digit is   " + input[last]);
            Console.ReadLine();

        }
    }
}
