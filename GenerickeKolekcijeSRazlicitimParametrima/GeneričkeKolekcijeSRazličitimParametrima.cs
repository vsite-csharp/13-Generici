using System;
using System.Collections.Generic;

namespace Vsite.CSharp.Generici
{
    class GeneričkeKolekcijeSRazličitimParametrima
    {
        public static void PridruživanjeDvijuKolekcijaSIstimParametrima()
        {

            Dictionary<string, int> brojevi = new Dictionary<string, int>();
            brojevi.Add("jedan", 1);
            brojevi.Add("dva", 2);
            brojevi.Add("tri", 3);

            foreach (var e in brojevi)
            {
                Console.WriteLine($@"""{e.Key}"" = {e.Value}");
            }

            Console.WriteLine();

            Dictionary<string, int> numbers = brojevi;

            foreach (var e in numbers)
            {
                Console.WriteLine($@"""{e.Key}"" = {e.Value}");
            }

        }

        public static void PridruživanjeDvijuKolekcijaSRazličitimParametrima()
        {
            Dictionary<string, string> numbers = new Dictionary<string, string>();
            numbers.Add("one", "jedan");
            numbers.Add("two", "dva");
            numbers.Add("three", "tri");

            Dictionary<string, int> brojevi;

            //brojevi = numbers;

            foreach (var e in numbers)
            {
                Console.WriteLine($"\"{e.Key}\" = {e.Value}");
            }
        }

        static void Main(string[] args)
        {
            PridruživanjeDvijuKolekcijaSIstimParametrima();

            PridruživanjeDvijuKolekcijaSRazličitimParametrima();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}
