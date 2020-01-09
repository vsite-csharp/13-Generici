using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp.Generici
{
    class OsobaPoVisini : IComparable<OsobaPoVisini>
    {
        public OsobaPoVisini(string ime, int visinaCm)
        {
            Ime = ime;
            Visina = visinaCm;
        }
        public int CompareTo(OsobaPoVisini other)
        {
            return Visina.CompareTo(other.Visina);
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
        public static T Manji<T>(T prvi, T drugi) where T:IComparable<T>
        {
            return prvi.CompareTo(drugi) < 0 ? prvi : drugi;
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
