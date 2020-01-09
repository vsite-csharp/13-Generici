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
            // TODO:000 U listu 'osobe' dodati dvije osobe s imenima "Ivica" i "Marica" te 
            //proizvoljnim datumima rođenja. Prevesti program, pokrenuti ga i provjeriti ispis.
            osobe.Add(new Osoba("Ivica", new DateTime(1991, 1, 1)));     //novo dodano
            osobe.Add(new Osoba("MArica", new DateTime(1993, 1, 1)));    //novo dodano

            foreach (Osoba osoba in osobe)
                Console.WriteLine(osoba.Ime);

            // TODO:001 U listu 'osobe' dodati objekt nekog drugog tipa. Prevesti program, pokrenuti ga i provjeriti ispis.
            osobe.Add(2);   //novo dodano baca exception za vrijeme izvođenja pa moramo to izbjeći 

            foreach (Osoba osoba in osobe)
                Console.WriteLine(osoba.Ime);
        }

        public static void GeneričkaKolekcija()
        {
            List<Osoba> osobe = new List<Osoba>();
            // TODO:002 Ponoviti dodavanja i ispise iz gornje metode. Prevesti program, pokrenuti ga i provjeriti ispis.
            osobe.Add(new Osoba("Ivica", new DateTime(1991, 1, 1)));     //novo dodano
            osobe.Add(new Osoba("Marica", new DateTime(1993, 1, 1)));    //novo dodano

            foreach (Osoba osoba in osobe)
                Console.WriteLine(osoba.Ime);
           // osobe.Add(2);   //javlja grešku i prije izvođenja
            foreach (Osoba osoba in osobe)
                Console.WriteLine(osoba.Ime);
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
