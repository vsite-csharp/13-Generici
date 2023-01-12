namespace Vsite.CSharp.Generici
{

    interface IŽivotinja
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
