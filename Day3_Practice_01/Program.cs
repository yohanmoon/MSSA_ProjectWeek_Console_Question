using System;

namespace Practice_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write C# program to print multiplication table of a given number

            Console.WriteLine("Write C# program to print multiplication table of a given number");
            Console.WriteLine("\n\n Choose a number : ");

            int input = Convert.ToInt32(Console.ReadLine());

            for (int i=1; i <=input; i++)
            {
                int answer = input * i;
                Console.WriteLine("\n"+ input + " x " + i +" = " + answer);

            }

            Console.ReadLine();
        }
    }
}
