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
            // :000 U listu 'osobe' dodati dvije osobe s imenima "Ivica" i "Marica" te proizvoljnim datumima rođenja. Prevesti program, pokrenuti ga i provjeriti ispis.
            osobe.Add(new Osoba("Ivica", new DateTime(1980, 2, 29)));
            osobe.Add(new Osoba("Marica", new DateTime(1993, 1, 1)));

            foreach (Osoba osoba in osobe)
                Console.WriteLine(osoba.Ime);

            // TODO:001 U listu 'osobe' dodati objekt nekog drugog tipa. Prevesti program, pokrenuti ga i provjeriti ispis.
            osobe.Add(23);

            foreach (Osoba osoba in osobe)
                Console.WriteLine(osoba.Ime);
        }

        public static void GeneričkaKolekcija()
        {
            List<Osoba> osobe = new List<Osoba>();
            // TODO:002 Ponoviti dodavanja i ispise iz gornje metode. Prevesti program, pokrenuti ga i provjeriti ispis.
            osobe.Add(new Osoba("Ivica", new DateTime(1980, 2, 29)));
            osobe.Add(new Osoba("Marica", new DateTime(1993, 1, 1)));
            //osobe.Add(2);

            foreach (Osoba osoba in osobe)
                Console.WriteLine(osoba.Ime);

            foreach (Osoba osoba in osobe)
                Console.WriteLine(osoba.Ime);

        }

        // TODO:003 Pokrenuti i provjeriti testove (2 testa u grupi "GeneričkeKolekcije" moraju proći)

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

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
