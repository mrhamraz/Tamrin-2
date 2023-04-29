using System;

namespace _8._Olempyad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your math grade :");
            int math = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your physics  grade :");
            int phys = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter your chemistry grade :");
            int chemi = Convert.ToInt32(Console.ReadLine());

            if (math > 16 && phys > 15 && chemi > 14)
                Console.WriteLine("Qualified for Olempyad");
            else
                Console.WriteLine("NOT Qualified for Olempyad");
        }
    }
}
