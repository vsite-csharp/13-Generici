using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp.Generici
{
    abstract class Zivotinja
    {
        public abstract void PokreniSe();
    }
    class Sisavac : Zivotinja
    {
        public override void PokreniSe()
        {
            Console.WriteLine("Trčim");
        }
    }

    class Gmaz : Zivotinja
    {
        public override void PokreniSe()
        {
            Console.WriteLine("Gmažem");
        }
    }

    class Riba : Zivotinja
    {
        public override void PokreniSe()
        {
            Console.WriteLine("Ribam");
        }
    }

    class Ptica : Zivotinja
    {
        public override void PokreniSe()
        {
            Console.WriteLine("P(t)ičim");
        }
    }
}
