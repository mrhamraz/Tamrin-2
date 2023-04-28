using System;

namespace _6._Height
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your heigth :");

            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0 && num < 150)
                Console.WriteLine("Short");

            else if (num > 150 && num < 165)
                Console.WriteLine("Average");

            else if (num > 165 && num < 195)
                Console.WriteLine("Tall");

            else if (num > 190)
                Console.WriteLine("Too tall");

            else
                Console.WriteLine("unknown");

        }
    } 
}
