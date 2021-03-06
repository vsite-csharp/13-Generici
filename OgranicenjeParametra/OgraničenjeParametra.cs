﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp.Generici
{
    // TODO:031 Dodati potrebne promjene da bi se OSobePoVisini mogle uspoređivati po njihovim visinam.
    class OsobaPoVisini
    {
        public OsobaPoVisini(string ime, int visinaCm)
        {
            Ime = ime;
            Visina = visinaCm;
        }

        public readonly string Ime;
        public readonly int Visina;

        public override string ToString()
        {
            return $"{Ime} ({Visina} cm)";
        }

    }

    class OgraničenjeParametra
    {
        // TODO:030 Definirati metodu Manji tako da vraća manji od dva proslijeđena argumenta pozivom njihove metode CompareTo iz sučelja IComparable<T>.
        public static T Manji<T>(T prvi, T drugi)
        {
            throw new NotImplementedException();
        }

        private static void IspišiManjiBroj(double prvi, double drugi)
        {
            Console.WriteLine($"Između {prvi} i {drugi}, manji je {Manji(prvi, drugi)}");
        }

        private static void IspišiManjiString(string prvi, string drugi)
        {
            Console.WriteLine($"Između '{prvi}' i '{drugi}', manji je '{Manji(prvi, drugi)}'");
        }

        private static void IspišiManjuOsobu(OsobaPoVisini prva, OsobaPoVisini druga)
        {
            Console.WriteLine($"Između '{prva}' i '{druga}', manji je '{Manji(prva, druga)}'");
        }

        // TODO:031 Pokrenuti program i provjeriti ispis.

        // TODO:032 Pokrenuti testove (3 testa u grupi "TestOgraničenjaParametra" moraju proći)

        static void Main(string[] args)
        {
            IspišiManjiBroj(1, 2.3);
            IspišiManjiString("Pero", "Maksimilijan");

            IspišiManjuOsobu(new OsobaPoVisini("Pero", 193), new OsobaPoVisini("Maksimilijan", 157));
            IspišiManjuOsobu(new OsobaPoVisini("Ante", 178), new OsobaPoVisini("Marko", 171));

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}
