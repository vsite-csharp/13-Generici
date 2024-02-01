namespace Vsite.CSharp.Generici
{

    // :010 Definirati sučelje (interface) IŽivotinja s metodom void PokreniSe().

    // :011 U deklariracijama donjih klasa navesti da sve one implementiraju sučelje IŽivotinja.

    public interface IŽivotinja
    {
        void PokreniSe();
    }

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
