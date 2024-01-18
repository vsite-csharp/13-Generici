namespace Vsite.CSharp.Generici
{
    internal class JelovnikStareVještice
    {
        // TODO:000 U klasu dodati kao član generičku klasu List<T> s elementima tipa Osoba.

        // TODO:001 U metodi DodajJelo implementirati dodavanje osobe u listu.
        public void DodajJelo(Osoba osoba)
        {
            osobe.Add(osoba);
        }

        // TODO:002 U metodi IspišiDnevniMenu implementirati kod koji će ispisati imena svih osoba.
        public void IspišiDnevniMenu()
        {
            foreach(var o in osobe)
            {
                Console.WriteLine(o.Ime);
            }
        }
        private readonly List<Osoba> osobe = new List<Osoba>();

    }

    internal static class GeneričkeKolekcije
    {

        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            var jsv = new JelovnikStareVještice();

            // TODO:003 dodati pozive metode DodajJelo za8 dvije osobe s imenima "Ivica" i "Marica" te proizvoljnim datumima rođenja.
            jsv.DodajJelo(new Osoba("Ivica", new DateTime(1945, 12, 3)));
            jsv.DodajJelo(new Osoba("Marica", new DateTime(1955, 12, 5)));
            // TODO:004 Prevesti program, pokrenuti ga i provjeriti ispis.
            // TODO:005 Pokrenuti i provjeriti testove (Oba testa u grupi "Kolekcije" moraju proći)
            jsv.IspišiDnevniMenu();

            Console.WriteLine("\nGOTOVO!!!");
        }
    }
}
