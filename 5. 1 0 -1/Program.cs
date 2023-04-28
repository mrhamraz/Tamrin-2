using System;

namespace _5._1_0__1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number :");

            int num = Convert.ToInt32(Console.ReadLine());

            if (num == 0)
                Console.WriteLine("0");
            else if (num > 0)
                Console.WriteLine("1");
            else if (num < 0)
                Console.WriteLine("-1");
        }
    }
}
