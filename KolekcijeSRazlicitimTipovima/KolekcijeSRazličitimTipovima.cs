using System;
using System.Collections;
using System.Collections.Generic;

namespace Vsite.CSharp.Generici
{
    class GeneričkeKolekcijeSaČlanovimaRazličitihTipova
    {
        public static void KretanjeŽivotinja()
        {
            // TODO:010 U datoteci Životinja.cs definirati sučelje (interface) IŽivotinja s metodom void PokreniSe().
            // TODO:011 U deklariracijama klasa Gmaz, Ptica, Riba i Sisavac navesti da one implementiraju sučelje IŽivotinja.

            // TODO:012 Klasu ArrayList nadomjestiti generičkom listom List<IŽivotinja>.
            List<IŽivotinja> živine = new List<IŽivotinja>();
            živine.Add(new Sisavac());
            živine.Add(new Gmaz());
            živine.Add(new Riba());
            živine.Add(new Ptica());

            // TODO:013 Otkomentirati naredbu u petlji, prevesti program, provjeriti da nema pogrešaka te pokrenuti program.
            foreach (var živina in živine)
            {
                živina.PokreniSe();
            }
        }

        // TODO:014 Pokrenuti i provjeriti testove (test u grupi "KolekcijeSaČlanovimaRazličitihTipova" mora proći)

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            KretanjeŽivotinja();

            Console.WriteLine("\nGOTOVO!!!");
        }
    }
}
