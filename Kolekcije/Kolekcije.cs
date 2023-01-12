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
            // TODO:000 U listu 'osobe' dodati dvije osobe s imenima "Ivica" i "Marica" te proizvoljnim datumima rođenja. Prevesti program, pokrenuti ga i provjeriti ispis.

            osobe.Add(new Osoba("Ivica",DateTime.Now));
            osobe.Add(new Osoba("Marica", DateTime.Now));
            foreach (Osoba osoba in osobe)
            {
                Console.WriteLine(osoba.Ime);
            }

            // TODO:001 U listu 'osobe' dodati objekt nekog drugog tipa. Prevesti program, pokrenuti ga i provjeriti ispis.
            osobe.Add(2);

            foreach (Osoba osoba in osobe)
            {
                Console.WriteLine(osoba.Ime);
            }
        }

        public static void GeneričkaKolekcija()
        {
            List<Osoba> osobe = new List<Osoba>();
            // TODO:002 Ponoviti dodavanja i ispise iz gornje metode. Prevesti program, pokrenuti ga i provjeriti ispis.
            osobe.Add(new Osoba("Ivica", DateTime.Now));
            osobe.Add(new Osoba("Marica", DateTime.Now));

            foreach (Osoba osoba in osobe)
            {
                Console.WriteLine(osoba.Ime);
            }

            // TODO:001 U listu 'osobe' dodati objekt nekog drugog tipa. Prevesti program, pokrenuti ga i provjeriti ispis.
            

            foreach (Osoba osoba in osobe)
            {
                Console.WriteLine(osoba.Ime);
            }
        }

        // TODO:003 Pokrenuti i provjeriti testove (2 testa u grupi "Kolekcije" moraju proći)

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

            Console.WriteLine("\nGeneričkaKolekcija:");
            GeneričkaKolekcija();

            Console.WriteLine("\nGOTOVO!!!");
        }
    }
}
