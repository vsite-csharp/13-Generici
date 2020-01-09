using System;
using System.Collections;
using System.Collections.Generic;

namespace Vsite.CSharp.Generici
{
    class GeneričkeKolekcije
    {
        public static void TipskiNesigurnaKolekcija()
        {
            ArrayList osobe = new ArrayList();
            osobe.Add(new Osoba("Ivica", new DateTime(1991, 1, 1)));
            osobe.Add(new Osoba("Marica", new DateTime(1993, 1, 1)));
            foreach (Osoba osoba in osobe)
                Console.WriteLine(osoba.Ime);

            osobe.Add(2);
            foreach (Osoba osoba in osobe)
                Console.WriteLine(osoba.Ime);
        }

        public static void GeneričkaKolekcija()
        {
            List<Osoba> osobe = new List<Osoba>();
            osobe.Add(new Osoba("Ivica", new DateTime(1991, 1, 1)));
            osobe.Add(new Osoba("Marica", new DateTime(1993, 1, 1)));
            foreach (Osoba osoba in osobe)
                Console.WriteLine(osoba.Ime);
            //osobe.Add(2);
            foreach(Osoba osoba in osobe)
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
