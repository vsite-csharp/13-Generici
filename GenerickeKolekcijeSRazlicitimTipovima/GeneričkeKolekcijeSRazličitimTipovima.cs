using System;
using System.Collections;
using System.Collections.Generic;

namespace Vsite.CSharp.Generici
{
    class GeneričkeKolekcijeSaČlanovimaRazličitihTipova
    {
        public static void KretanjeŽivotinja()
        {

            // TODO:011 Klasu ArrayList nadomjestiti generičkom listom List<Životinja>. Otkomentirati naredbu u petlji, prevesti program i provjeriti da nema pogrešaka.
            List<Životnija> živine = new List<Životnija>();
            živine.Add(new Sisavac());
            živine.Add(new Gmaz());
            živine.Add(new Riba());
            živine.Add(new Ptica());

            foreach (var živina in živine)
            {
                živina.PokreniSe();
            }
        }


        static void Main(string[] args)
        {
            KretanjeŽivotinja();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}
