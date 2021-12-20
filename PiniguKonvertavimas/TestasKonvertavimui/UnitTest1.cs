using Microsoft.VisualStudio.TestTools.UnitTesting;
using PiniguKonvertavimas;

namespace TestasKonvertavimui
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            int kiekis = 100;
            decimal kursas = 4.59m;
            decimal expectedResult = 459.00m;
            string valiuta = "PLN";

            var actualResult = Program.Konvertavimas(kiekis,kursas,valiuta);

            Assert.AreEqual(expectedResult, actualResult);  

        }
    }
}
