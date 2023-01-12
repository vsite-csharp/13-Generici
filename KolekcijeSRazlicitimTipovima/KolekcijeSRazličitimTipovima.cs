using System;
using System.Collections;
using System.Collections.Generic;

namespace Vsite.CSharp.Generici
{
    class GeneričkeKolekcijeSaČlanovimaRazličitihTipova
    {
        public static void KretanjeŽivotinja()
        {
            // U datoteci Životinja.cs definirati sučelje (interface) IŽivotinja s metodom void PokreniSe().
            // U deklariracijama klasa Gmaz, Ptica, Riba i Sisavac navesti da one implementiraju sučelje IŽivotinja.

            // Klasu ArrayList nadomjestiti generičkom listom List<IŽivotinja>.
            var živine = new List<IŽivotinja>();
            živine.Add(new Sisavac());
            živine.Add(new Gmaz());
            živine.Add(new Riba());
            živine.Add(new Ptica());

            // Otkomentirati naredbu u petlji, prevesti program, provjeriti da nema pogrešaka te pokrenuti program.
            foreach (var živina in živine)
            {
                živina.PokreniSe();
            }
        }

        // Pokrenuti i provjeriti testove (test u grupi "KolekcijeSaČlanovimaRazličitihTipova" mora proći)

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            KretanjeŽivotinja();

            Console.WriteLine("\nGOTOVO!!!");
        }
    }
}
