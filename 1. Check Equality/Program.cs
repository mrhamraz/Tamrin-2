using System;

namespace _1._Check_Equality
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter to numbers to check the equality : ");

            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
            
                Console.WriteLine("EQUAL");

            else
                Console.WriteLine("NOT EQUAL");

        }
    }
}
