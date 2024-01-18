namespace Vsite.CSharp.Generici
{
    static internal class GeneričkeKolekcijeSČlanovimaRazličitihTipova
    {
        public static void MigracijaŽivotinja()
        {

            // 012 Inicijalizirati varijablu životinjskoCarstvo generičkom listom List<IŽivotinja>.
            var životinjskoCarstvo = new List<IŽivotinja>();

            // 013 Otkomentirati donje naredbe te prevesti i pokrenuti program.
            životinjskoCarstvo.Add(new Sisavac());
            životinjskoCarstvo.Add(new Gmaz());
            životinjskoCarstvo.Add(new Riba());
            životinjskoCarstvo.Add(new Ptica());

            foreach (var životinja in životinjskoCarstvo)
            {
                životinja.PokreniSe();
            }
        }

        // TODO:014 Pokrenuti i provjeriti testove (test u grupi "KolekcijeSČlanovimaRazličitihTipova" mora proći)

        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            MigracijaŽivotinja();

            Console.WriteLine("\nGOTOVO!!!");
        }
    }
}
