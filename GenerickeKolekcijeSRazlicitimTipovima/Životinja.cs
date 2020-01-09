using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp.Generici
{ 
    abstract class Životnija
{
    public abstract void PokreniSe();
}

    class Sisavac : Životnija
    {
        public override void PokreniSe()
        {
            Console.WriteLine("Trčim");
        }

    
    }

    class Gmaz : Životnija
    {
        public override void PokreniSe()
        {
            Console.WriteLine("Gmažem");
        }
    }

    class Riba : Životnija
    {
        public override void PokreniSe()
        {
            Console.WriteLine("Ribam");
        }
    }

    class Ptica : Životnija
    {
        public override void PokreniSe()
        {
            Console.WriteLine("P(t)ičim");
        }
    }
}
