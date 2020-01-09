using System;
using System.Collections;
using System.Collections.Generic;

namespace Vsite.CSharp.Generici
{
    class GeneričkeKolekcijeSaČlanovimaRazličitihTipova
    {
        public static void KretanjeŽivotinja()
        {
            List<Životinja> živine = new List<Životinja>();
            živine.Add(new Sisavac());
            živine.Add(new Gmaz());
            živine.Add(new Riba());
            živine.Add(new Ptica());

            foreach (var živina in živine)
            {
                živina.PokreniSe();
            }
        }

        // TODO:012 Pokrenuti i provjeriti testove (test u grupi "TestGeneričkeKolekcijeSaČlanovimaRažličitihTipova" mora proći)

        static void Main(string[] args)
        {
            KretanjeŽivotinja();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}
