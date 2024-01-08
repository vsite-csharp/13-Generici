namespace Vsite.CSharp.Generici
{
    class Osoba
    {
        public Osoba(string ime, DateTime datumRodjenja)
        {
            Ime = ime;
            DatumRodjenja = datumRodjenja;
        }

        public readonly string Ime;
        public readonly DateTime DatumRodjenja;
    }
}
