namespace Vsite.CSharp.Generici
{

    // TODO:010 Definirati sučelje (interface) IŽivotinja s metodom void PokreniSe().

    // TODO:011 U deklariracijama donjih klasa navesti da sve one implementiraju sučelje IŽivotinja.
    class Sisavac
    {
        public void PokreniSe()
        {
            Console.WriteLine("Trčim");
        }
    }

    class Gmaz
    {
        public void PokreniSe()
        {
            Console.WriteLine("Gmažem");
        }
    }

    class Riba
    {
        public void PokreniSe()
        {
            Console.WriteLine("Ribam");
        }
    }

    class Ptica
    {
        public void PokreniSe()
        {
            Console.WriteLine("P(t)ičim");
        }
    }
}
