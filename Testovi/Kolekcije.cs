namespace Vsite.CSharp.Generici.Testovi
{
    [TestClass]
    public class GeneričKeKolekcije : ConsoleTest
    {
        [TestMethod]
        public void TestGeneričkaKolekcijeZaJednuOsobu()
        {
            var jsv = new Generici.JelovnikStareVještice();
            jsv.DodajJelo(new Osoba("Marica", DateTime.Now));
            jsv.IspišiDnevniMenu();
            Assert.IsTrue(cw?.Count == 1);
            Assert.AreEqual("Marica", cw.GetString());
        }

        [TestMethod]
        public void TestGeneričkaKolekcijeZaDvijeOsobe()
        {
            var jsv = new Generici.JelovnikStareVještice();
            jsv.DodajJelo(new Osoba("Ivica", DateTime.Now));
            jsv.DodajJelo(new Osoba("Marica", DateTime.Now));
            jsv.IspišiDnevniMenu();
            Assert.IsTrue(cw?.Count == 2);
            Assert.AreEqual("Ivica", cw.GetString());
            Assert.AreEqual("Marica", cw.GetString());
        }
    }
}
