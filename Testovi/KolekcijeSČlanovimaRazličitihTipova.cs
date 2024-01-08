namespace Vsite.CSharp.Generici.Testovi
{
    [TestClass]
    public class GeneričkeKolekcijeSČlanovimaRazličitihTipova : ConsoleTest
    {
        [TestMethod]
        public void UGeneričkuKolekcijuŽivotinjaMoguSeDodavatiIzvedeniObjekti()
        {
            Generici.GeneričkeKolekcijeSČlanovimaRazličitihTipova.MigracijaŽivotinja();
            Assert.AreEqual(4, cw?.Count);
            Assert.IsTrue(cw?.Contains("P(t)ičim"));
            Assert.IsTrue(cw?.Contains("Gmažem"));
            Assert.IsTrue(cw?.Contains("Trčim"));
            Assert.IsTrue(cw?.Contains("Ribam"));
        }
    }
}
