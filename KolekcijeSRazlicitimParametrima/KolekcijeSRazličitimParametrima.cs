﻿namespace Vsite.CSharp.Generici
{
    internal static class GeneričkeKolekcijeSRazličitimParametrima
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

            // TODO:021 Inicijalizirati novi rječnik tipa Dictionary<string, int>, pridružiti mu sadržaj rječnika 'brojevi' te ponoviti ispis svih članova novog rječnika. 

            // TODO:022 Prevesti program, pokrenuti ga i provjeriti ispis.

        }

        public static void PridruživanjeDvijuKolekcijaSRazličitimParametrima()
        {
            Dictionary<string, string> numbers = new Dictionary<string, string>();
            numbers.Add("one", "jedan");
            numbers.Add("two", "dva");
            numbers.Add("three", "tri");

            // TODO:023 Inicijalizirati novi rječnik 'brojevi' tipa Dictionary<string, int>

            // TODO:024 Otkomentirati donju naredbu i provjerite pogrešku koju prevoditelj prijavljuje.
            //brojevi = numbers;

            foreach (var e in numbers)
            {
                Console.WriteLine($"\"{e.Key}\" = {e.Value}");
            }
        }

        // TODO:025 Pokrenuti i provjeriti testove (test u grupi "KolekcijeSRazličitimParametrima" mora proći)

        static void Main()
        {
            PridruživanjeDvijuKolekcijaSIstimParametrima();

            PridruživanjeDvijuKolekcijaSRazličitimParametrima();

            Console.WriteLine("\nGOTOVO!!!");
        }
    }
}
