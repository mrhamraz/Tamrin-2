using System;

namespace _12._Find_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter num :");

            string num = Console.ReadLine();

            if ((num[num.Length - 1]) == '3')
                Console.WriteLine("Find");
            else
                Console.WriteLine("no");
        }
    }
}
