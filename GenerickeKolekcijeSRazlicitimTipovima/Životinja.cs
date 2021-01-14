using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp.Generici
{

    abstract class Životinje
    {
        public abstract void PokreniSe();
        

    
        class Sisavac : Životinje
        {

            public override void PokreniSe()
            {
                Console.WriteLine("Trčim");
            }
        }

        class Gmaz : Životinje
        {
            public override void PokreniSe()
            {
                Console.WriteLine("Gmažem");
            }
        }

        class Riba : Životinje
        {
            public override void PokreniSe()
            {
                Console.WriteLine("Ribam");
            }
        }

        class Ptica : Životinje
        {
            public override void PokreniSe()
            {
                Console.WriteLine("P(t)ičim");
            }
        }
    }

