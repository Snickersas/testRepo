using Microsoft.VisualStudio.TestTools.UnitTesting;
using VII_Paskaita;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            //arrange (sukuriam data)

            decimal pajamos = 350m;
            decimal expectedResult = 17.5m;
            //act (callinam metoda)

            var actualResult=Program.SkaiciuotiMokescius(pajamos);


            //assert (lyginam expected su actual output)


            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}