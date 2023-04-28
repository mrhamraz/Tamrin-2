using System;

namespace _3._Check_Positive_or_Negative
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter number to check the sign of it  :");

            int num = Convert.ToInt32(Console.ReadLine());

            if (num >= 0)

                Console.WriteLine("Positive");

            else
                Console.WriteLine("Negative");
        }
    }
}
