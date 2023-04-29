using System;

namespace _10._Vowel_chars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a character to check if it's vowel :");

            char Char = Convert.ToChar(Console.ReadLine());

            Char = Char.ToLower(Char);

            switch (Char)
            {
                case 'a':
                    Console.WriteLine("Vowel!");
                    break;
                case 'e':
                    Console.WriteLine("Vowel!");
                    break;
                case 'i':
                    Console.WriteLine("Vowel!");
                    break;
                case 'o':
                    Console.WriteLine("Vowel!");
                    break;
                case 'u':
                    Console.WriteLine("Vowel!");
                    break;
                default:
                    Console.WriteLine("Not Vowel!");
                    break;
            }
        }
    }
}
