using System;
using System.Linq;

namespace _4._Leap_year
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter year like 1402 to check if it's Leap or not :");

            int year = Convert.ToInt32(Console.ReadLine());
            int remain = year % 33;
            int[] remainAray = { 1, 5, 9, 13, 17, 21, 26, 30 };


            //using System.Linq for [].Contains
            if (remainAray.Contains(remain))
           // if ((new[] { 1, 5, 9, 13, 17, 21, 26, 30 }).Contains(remain))

                Console.WriteLine("Leap!");

            else
                Console.WriteLine("Not Leap");


            ////////////////////////////////////////////
            

            //bool exist = Array.Exists(reaminAray, element => element == remain);

            //if (exist)  
            //    Console.WriteLine("Leap!");

            //else
            //    Console.WriteLine("Not Leap");

            ////////////////////////////////////////////

            //switch (remain)
            //{
            //    case 1:
            //        Console.WriteLine("Leap!");
            //        break;
            //    case 5:
            //        Console.WriteLine("Leap!");
            //        break;
            //    case 9:
            //        Console.WriteLine("Leap!");
            //        break;
            //    case 13:
            //        Console.WriteLine("Leap!");
            //        break;
            //    case 17:
            //        Console.WriteLine("Leap!");
            //        break;
            //    case 21:
            //        Console.WriteLine("Leap!");
            //        break;
            //    case 26:
            //        Console.WriteLine("Leap!");
            //        break;
            //    case 30:
            //        Console.WriteLine("Leap!");
            //        break;

            //    default:
            //        Console.WriteLine("Not Leap");
            //        break;




        }
    }
}
