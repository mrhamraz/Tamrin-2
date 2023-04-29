using System;

namespace _9._Type_of_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 sides of triangel to check the type :");

            int side1 = Convert.ToInt32(Console.ReadLine());
            int side2 = Convert.ToInt32(Console.ReadLine());
            int side3 = Convert.ToInt32(Console.ReadLine());



            if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
            {
                if (side1 == side2 && side1 == side3)
                    Console.WriteLine("Equilateral (motsavi azlaa)");

                else if (side1 == side2 || side2 == side3 || side1 == side3)
                    Console.WriteLine("Isosceles! (saghein)");

                else
                    Console.WriteLine("Normal");
            }

            else
                Console.WriteLine("NOT Qualified to make a triangle");
        }
    }
}
