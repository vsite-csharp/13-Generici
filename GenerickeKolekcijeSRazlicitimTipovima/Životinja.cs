using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp.Generici
{
    abstract class životinja
    {
        public abstract void PokreniSe();
    }
    class Sisavac : životinja
    {
        public override void PokreniSe()
        {
            Console.WriteLine("Trčim");
        }
    }

    class Gmaz : životinja
    {
        public override void PokreniSe()
        {
            Console.WriteLine("Gmažem");
        }
    }

    class Riba : životinja
    {
        public override void PokreniSe()
        {
            Console.WriteLine("Ribam");
        }
    }

    class Ptica : životinja
    {
        public override void PokreniSe()
        {
            Console.WriteLine("P(t)ičim");
        }
    }
}
