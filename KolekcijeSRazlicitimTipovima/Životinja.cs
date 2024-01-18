namespace Vsite.CSharp.Generici
{

    // TODO:010 Definirati sučelje (interface) IŽivotinja s metodom void PokreniSe().
    interface IŽivotinja
    {
        void PokreniSe();
    }
    // TODO:011 U deklariracijama donjih klasa navesti da sve one implementiraju sučelje IŽivotinja.
    class Sisavac : IŽivotinja
    {
        public void PokreniSe()
        {
            Console.WriteLine("Trčim");
        }
    }

    class Gmaz : IŽivotinja
    {
        public void PokreniSe()
        {
            Console.WriteLine("Gmažem");
        }
    }

    class Riba : IŽivotinja
    {
        public void PokreniSe()
        {
            Console.WriteLine("Ribam");
        }
    }

    class Ptica : IŽivotinja
    {
        public void PokreniSe()
        {
            Console.WriteLine("P(t)ičim");
        }
    }
}
