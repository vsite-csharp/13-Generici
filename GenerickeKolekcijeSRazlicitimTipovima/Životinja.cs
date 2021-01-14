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

    /// <summary>
    /// ili
    /// </summary>
    //interface Životinja
    //{
    //    void PokreniSe();
    //}
    //kad je interface onda dole u kodu ne treba override

    class Sisavac :  Životinja
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
