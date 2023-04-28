using System;

namespace _2._Check_Even_or_Odd
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter number to check if it's even or odd :");

            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)

                Console.WriteLine("Even");

            else
                Console.WriteLine("Odd");
        }
    }
}
