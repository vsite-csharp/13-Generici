using System;
using System.Collections;
using System.Collections.Generic;

namespace Vsite.CSharp.Generici
{
    class GeneričkeKolekcijeSaČlanovimaRazličitihTipova
    {
        public static void KretanjeŽivotinja()
        {
            // U datoteci Životinja.cs definirati apstraktnu klasu Životinja s apstraktnom (dakle virtualnom!) metodom void PokreniSe(). Proglasiti tu klasu baznom klasom za klase Gmaz, Ptica, Riba i Sisavac te prilagoditi potpise njihovih metoda PokreniSe.

            // Klasu ArrayList nadomjestiti generičkom listom List<Životinja>. Otkomentirati naredbu u petlji, prevesti program i provjeriti da nema pogrešaka.
            List<Životinja> živine = new List<Životinja>();
            //ArrayList živine = new ArrayList();
            živine.Add(new Sisavac());
            živine.Add(new Gmaz());
            živine.Add(new Riba());
            živine.Add(new Ptica());

            foreach (var živina in živine)
            {
                živina.PokreniSe();
            }
        }

        // Pokrenuti i provjeriti testove (test u grupi "TestGeneričkeKolekcijeSaČlanovimaRažličitihTipova" mora proći)

        static void Main(string[] args)
        {
            KretanjeŽivotinja();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}
