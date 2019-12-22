using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.Generici.Testovi
{
    [TestClass]
    public class TestGeneričkeKolekcijeSaČlanovimaRažličitihTipova : ConsoleTest
    {
        [TestMethod]
        public void GeneričkeKolekcijeSaČlanovimaRažličitihTipova()
        {
            GeneričkeKolekcijeSaČlanovimaRazličitihTipova.KretanjeŽivotinja();
            Assert.AreEqual(4, cw.Count);
            Assert.IsTrue(cw.Contains("P(t)ičim"));
            Assert.IsTrue(cw.Contains("Gmažem"));
            Assert.IsTrue(cw.Contains("Trčim"));
            Assert.IsTrue(cw.Contains("Ribam"));
        }
    }
}
