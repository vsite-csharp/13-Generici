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
            throw new NotImplementedException();
        }
    }

    class Gmaz: Životinja
    {

        public override void PokreniSe()
        {
            throw new NotImplementedException();
        }
    }

    class Riba:Životinja
    {
        public override void PokreniSe()
        {
            Console.WriteLine("Ribam");
        }
    }

    class Ptica:Životinja
    {
        public override void PokreniSe()
        {
            Console.WriteLine("P(t)ičim");
        }
    }
}
