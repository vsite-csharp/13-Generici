using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.Generici.Testovi
{
    [TestClass]
    public class GeneričkeKolekcijeSRazličitimParametrima : ConsoleTest
    {
        [TestMethod]
        public void PridruživanjeDvijuKolekcijaSIstimParametrima()
        {
            Generici.GeneričkeKolekcijeSRazličitimParametrima.PridruživanjeDvijuKolekcijaSIstimParametrima();
            Assert.AreEqual(6, cw.Count);
            Assert.AreEqual("\"jedan\" = 1", cw.GetString());
            Assert.AreEqual("\"dva\" = 2", cw.GetString());
            Assert.AreEqual("\"tri\" = 3", cw.GetString());
            Assert.AreEqual("\"jedan\" = 1", cw.GetString());
            Assert.AreEqual("\"dva\" = 2", cw.GetString());
            Assert.AreEqual("\"tri\" = 3", cw.GetString());
        }
    }
}
