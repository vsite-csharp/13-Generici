﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Vsite.CSharp.Generici
{
    class GeneričkeKolekcije
    {
        public static void TipskiNesigurnaKolekcija()
        {
            ArrayList osobe = new ArrayList();
            // U listu 'osobe' dodati dvije osobe s imenima "Ivica" i "Marica" te proizvoljnim datumima rođenja. Prevesti program, pokrenuti ga i provjeriti ispis.
            osobe.Add(new Osoba("Ivica", DateTime.Now));
            osobe.Add(new Osoba("Marica", DateTime.Now));

            foreach (Osoba osoba in osobe)
                Console.WriteLine(osoba.Ime);

            // U listu 'osobe' dodati objekt nekog drugog tipa. Prevesti program, pokrenuti ga i provjeriti ispis.
            osobe.Add(1);


            foreach (Osoba osoba in osobe)
                Console.WriteLine(osoba.Ime);
        }

        public static void GeneričkaKolekcija()
        {
            List<Osoba> osobe = new List<Osoba>();
            // Ponoviti dodavanja i ispise iz gornje metode. Prevesti program, pokrenuti ga i provjeriti ispis.
            osobe.Add(new Osoba("Ivica", DateTime.Now));
            osobe.Add(new Osoba("Marica", DateTime.Now));

            osobe.ForEach(o => Console.WriteLine(o.Ime));

            //osobe.Add(1);
        }

        // TODO:003 Pokrenuti i provjeriti testove (2 testa u grupi "TestGeneričkeKolekcije" moraju proći)

        static void Main(string[] args)
        {
            Console.WriteLine("TipskiNesigurnaKolekcija:");
            try
            {
                TipskiNesigurnaKolekcija();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("GeneričkaKolekcija:");
            GeneričkaKolekcija();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}
