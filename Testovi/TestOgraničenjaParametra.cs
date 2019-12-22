using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.Generici.Testovi
{
    [TestClass]
    public class TestOgraničenjaParametra
    {
        [TestMethod]
        public void UsporedbaDvaBrojaTipaDoubleVraćaManji()
        {
            Assert.AreEqual(2.3, OgraničenjeParametra.Manji(2.3, 5.7));
        }

        [TestMethod]
        public void UsporedbaDvaStringaVraćaOnajKojiPrethodiPoAbecedi()
        {
            Assert.AreEqual("auto", OgraničenjeParametra.Manji("auto", "mama"));
        }

        [TestMethod]
        public void UsporedbaDvaDatumaVraćaStarijiDatum()
        {
            Assert.AreEqual(new DateTime(2014, 8, 27), OgraničenjeParametra.Manji(new DateTime(2014, 8, 28), new DateTime(2014, 8, 27)));
        }

        [TestMethod]
        public void UsporedbaDvijuOsobaVraćaOsobuSManjomVisinom()
        {
            Assert.AreEqual("Maksimilijan", OgraničenjeParametra.Manji(new OsobaPoVisini("Pero", 193), new OsobaPoVisini("Maksimilijan", 157)).Ime);
            Assert.AreEqual("Marko", OgraničenjeParametra.Manji(new OsobaPoVisini("Ante", 178), new OsobaPoVisini("Marko", 171)).Ime);
        }
    }
}
