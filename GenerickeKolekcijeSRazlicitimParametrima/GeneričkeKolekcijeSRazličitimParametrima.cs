using System;
using System.Collections.Generic;

namespace Vsite.CSharp.Generici
{
    class GeneričkeKolekcijeSRazličitimParametrima
    {
        public static void PridruživanjeDvijuKolekcijaSIstimParametrima()
        {
            // TODO:020 Pokrenuti program i provjeriti ispise.

            Dictionary<string, int> brojevi = new Dictionary<string, int>();
            brojevi.Add("jedan", 1);
            brojevi.Add("dva", 2);
            brojevi.Add("tri", 3);

            foreach (var e in brojevi)
            {
                Console.WriteLine($@"""{e.Key}"" = {e.Value}");
            }

            Console.WriteLine();

            // Inicijalizirati novi rječnik tipa Dictionary<string, int>, pridružiti mu sadržaj rječnika 'brojevi' te ponoviti ispis svih članova novog rječnika. 
            Dictionary<string, int> d = brojevi;

            foreach (var e in d)
            {
                Console.WriteLine($@"""{e.Key}"" = {e.Value}");
            }

            Console.WriteLine();
            // Prevesti program, pokrenuti ga i provjeriti ispis.


        }

        public static void PridruživanjeDvijuKolekcijaSRazličitimParametrima()
        {
            Dictionary<string, string> numbers = new Dictionary<string, string>();
            numbers.Add("one", "jedan");
            numbers.Add("two", "dva");
            numbers.Add("three", "tri");

            // Inicijalizirati novi rječnik 'brojevi' tipa Dictionary<string, int>
            Dictionary<string, int> brojevi = new Dictionary<string, int>();

            // Otkomentirati donju naredbu i provjerite pogrešku koju prevoditelj prijavljuje.
            //brojevi = numbers;

            foreach (var e in numbers)
            {
                Console.WriteLine($"\"{e.Key}\" = {e.Value}");
            }
        }

        // Pokrenuti i provjeriti testove (test u grupi "TestGeneričkeKolekcijeSRazličitimParametrima" mora proći)

        static void Main(string[] args)
        {
            PridruživanjeDvijuKolekcijaSIstimParametrima();

            PridruživanjeDvijuKolekcijaSRazličitimParametrima();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}
