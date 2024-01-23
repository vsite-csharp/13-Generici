namespace Vsite.CSharp.Generici
{
    internal class JelovnikStareVještice
    {
        // TODO:000 U klasu dodati kao član generičku klasu List<T> s elementima tipa Osoba.

        // TODO:001 U metodi DodajJelo implementirati dodavanje osobe u listu.
        public void DodajJelo(Osoba osoba)
        {

        }

        // TODO:002 U metodi IspišiDnevniMenu implementirati kod koji će ispisati imena svih osoba.
        public void IspišiDnevniMenu()
        {

        }
    }

    internal static class GeneričkeKolekcije
    {

        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            var jsv = new JelovnikStareVještice();

            // TODO:003 dodati pozive metode DodajJelo za dvije osobe s imenima "Ivica" i "Marica" te proizvoljnim datumima rođenja.

            // TODO:004 Prevesti program, pokrenuti ga i provjeriti ispis.
            // TODO:005 Pokrenuti i provjeriti testove (Oba testa u grupi "GeneričkeKolekcije" moraju proći)
            jsv.IspišiDnevniMenu();

            Console.WriteLine("\nGOTOVO!!!");
        }
    }
}
