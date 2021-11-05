using System;

namespace Practice_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5] { 5, 6, 8, 2, 4 };
            int[] numbers2 = new int[6] { 1, 9, 8, 3, 7, 7 };

            int[] numbers3 = new int[numbers.Length + numbers2.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers3[i] = numbers[i];
            }

            for (int i = 0; i < numbers2.Length; i++)
            {
                numbers3[i + numbers.Length] = numbers2[i];
            }
            
            
            Console.WriteLine("\n\nFor Loop answer: \n");
            for (int i =0; i<numbers3.Length; i++)
            {

                Console.WriteLine(numbers3[i]);
            }
            
                        
            Console.WriteLine("\n\n\n\n\nForeach loop answer: \n");
            foreach(int i in numbers3)
            {
                 Console.WriteLine(i);
            }
        }

    }
}
