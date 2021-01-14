using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.Generici.Testovi
{
    [TestClass]
    public class TestGeneričkeKolekcije : ConsoleTest
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]
        public void TipskiNesigurneKolekcije()
        {
            try
            {
                GeneričkeKolekcije.TipskiNesigurnaKolekcija();
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
            GeneričkeKolekcije.GeneričkaKolekcija();
            Assert.AreEqual(2, cw.Count);
            Assert.AreEqual("Ivica", cw.GetString());
            Assert.AreEqual("Marica", cw.GetString());
        }
    }
}
