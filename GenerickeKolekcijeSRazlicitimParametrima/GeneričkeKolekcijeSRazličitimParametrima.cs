﻿using System;
using System.Collections.Generic;

namespace Vsite.CSharp.Generici
{
    class GeneričkeKolekcijeSRazličitimParametrima
    {
        public static void PridruživanjeDvijuKolekcijaSIstimParametrima()
        {
            // :020 Pokrenuti program i provjeriti ispise.

            Dictionary<string, int> brojevi = new Dictionary<string, int>();
            brojevi.Add("jedan", 1);
            brojevi.Add("dva", 2);
            brojevi.Add("tri", 3);

            foreach (var e in brojevi)
            {
                Console.WriteLine($@"""{e.Key}"" = {e.Value}");
            }

            Console.WriteLine();

            // :021 Inicijalizirati novi rječnik tipa Dictionary<string, int>, pridružiti mu sadržaj rječnika 'brojevi' te ponoviti ispis svih članova novog rječnika. 
            Dictionary<string, int> brojevi2 = new Dictionary<string, int>(brojevi);

            // :022 Prevesti program, pokrenuti ga i provjeriti ispis.

            foreach (var e in brojevi2)
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

            // :023 Inicijalizirati novi rječnik 'brojevi' tipa Dictionary<string, int>
            //Dictionary<string, int> numbers2 = new Dictionary<string, int>(numbers);
            // :024 Otkomentirati donju naredbu i provjerite pogrešku koju prevoditelj prijavljuje.
            //brojevi = numbers;

            foreach (var e in numbers)
            {
                Console.WriteLine($"\"{e.Key}\" = {e.Value}");
            }
        }

        // :025 Pokrenuti i provjeriti testove (test u grupi "GeneričkeKolekcijeSRazličitimParametrima" mora proći)

        static void Main(string[] args)
        {
            PridruživanjeDvijuKolekcijaSIstimParametrima();

            PridruživanjeDvijuKolekcijaSRazličitimParametrima();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}
