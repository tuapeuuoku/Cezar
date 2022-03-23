using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Szyfr_cezara
{
    class Program
    {


        public static char szyfr(char ch, int key)
        {
            if (!char.IsLetter(ch))
            {

                return ch;
            }

            char d = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - d) % 26) + d);


        }


        public static string Zaszyfruj(string input, int key)
        {
            string output = string.Empty;

            foreach (char ch in input)
                output += szyfr(ch, key);

            return output;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("podaj ciąg znaków do zaszyfrowania:");
            string UserString = Console.ReadLine();

            Console.WriteLine("\n");

            Console.Write("wprowadź klucz");
            int key = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");


            Console.WriteLine("Encrypted Data");

            string cipherText = Zaszyfruj(UserString, key);
            Console.WriteLine(cipherText);
            Console.Write("\n");





            Console.ReadKey();

        }
    }
}
