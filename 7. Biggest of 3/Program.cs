using System;

namespace _7._Biggest_of_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 numbers to check the biggest :");

            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
                Console.WriteLine("Number 1 is biggest.");

            else if (num2 > num1 && num2 > num3)
                Console.WriteLine("Number 2 is biggest.");

            else if (num3 > num1 && num3 > num2)
                Console.WriteLine("Number 3 is biggest.");

            else if (num1 == num2 || num1 == num3 || num2 == num3)
                Console.WriteLine("Don't enter equal inputs!!");

            
            //int[] array = { };
            //Array.Sort(array);

        }
    }
}
