using System;
using System.Linq;

namespace _11._Vowel__if_
{

        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter a character to check if it's vowel :");

                char Char = Convert.ToChar(Console.ReadLine());

                Char = Char.ToLower(Char);

                char[] vowel = { 'a','e','i','o','u' };


                //using System.Linq for [].Contains
                if (vowel.Contains(Char))
                    // if ((new[] { 'a','e','i','o','u'}).Contains(Char))

                    Console.WriteLine("Vowel");

                else
                    Console.WriteLine("Not Vowel");
            }
        }
    
}
    

