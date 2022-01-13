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
            osobe.Add(new Osoba("Đuro", new DateTime(1988, 2, 29)));
            osobe.Add(new Osoba("Milivoje", new DateTime(1968, 2, 19)));

            foreach (Osoba osoba in osobe)
                Console.WriteLine(osoba.Ime);

            // :001 U listu 'osobe' dodati objekt nekog drugog tipa. Prevesti program, pokrenuti ga i provjeriti ispis.
            osobe.Add(23);

            //foreach (Osoba osoba in osobe)
            //    Console.WriteLine(osoba.Ime);
        }

        public static void GeneričkaKolekcija()
        {
            List<Osoba> osobe = new List<Osoba>();
            // :002 Ponoviti dodavanja i ispise iz gornje metode. Prevesti program, pokrenuti ga i provjeriti ispis.
            osobe.Add(new Osoba("Đuro", new DateTime(1988, 2, 29)));
            osobe.Add(new Osoba("Milivoje", new DateTime(1968, 2, 19)));
            //osobe.Add(22); //0 bodova 

            foreach (Osoba osoba in osobe)
                Console.WriteLine(osoba.Ime);
        }

        // :003 Pokrenuti i provjeriti testove (2 testa u grupi "GeneričkeKolekcije" moraju proći)

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
