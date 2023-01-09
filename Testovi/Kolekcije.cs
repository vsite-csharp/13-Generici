using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.Generici.Testovi
{
    [TestClass]
    public class GeneričkeKolekcije : ConsoleTest
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]
        public void TipskiNesigurneKolekcije()
        {
            try
            {
                Generici.GeneričkeKolekcije.TipskiNesigurnaKolekcija();
            }
            catch (Exception)
            {
                Assert.AreEqual(4, cw.Count);
                Assert.AreEqual("Ivica", cw.GetString());
                Assert.AreEqual("Marica", cw.GetString());
                Assert.AreEqual("Ivica", cw.GetString());
                Assert.AreEqual("Marica", cw.GetString());
                throw;
            }
        }

        [TestMethod]
        public void GeneričkaKolekcija()
        {
            Generici.GeneričkeKolekcije.GeneričkaKolekcija();
            Assert.IsTrue(cw.Count == 2 || cw.Count == 4);
            Assert.AreEqual("Ivica", cw.GetString());
            Assert.AreEqual("Marica", cw.GetString());
            if (cw.Count == 4)
            {
                Assert.AreEqual("Ivica", cw.GetString());
                Assert.AreEqual("Marica", cw.GetString());
            }
        }
    }
}
