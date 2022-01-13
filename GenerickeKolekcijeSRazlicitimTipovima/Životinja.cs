using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp.Generici
{
    abstract class Životinja
    {
        public abstract void PokreniSe();
    }
    class Sisavac : Životinja
    {
        
        public override void PokreniSe()
        {
            Console.WriteLine("Trčim");
        }

    }

    class Gmaz : Životinja
    {
        public override void PokreniSe()
        {
            Console.WriteLine("Gmažem");
        }
    }

    class Riba : Životinja
    {
        public override void PokreniSe()
        {
            Console.WriteLine("Ribam");
        }
    }

    class Ptica : Životinja
    {
        public override void PokreniSe()
        {
            Console.WriteLine("P(t)ičim");
        }
    }
}
