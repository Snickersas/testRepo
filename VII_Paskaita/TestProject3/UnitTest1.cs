using NUnit.Framework;
using VII_Paskaita;

namespace TestProject3
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test1()
        {

            //arrange (sukuriam data)

            decimal pajamos = 350m;
            decimal expectedResult = 17.5m;

            //act (callinam metoda)

            var actualResult = Program.SkaiciuotiMokescius(pajamos);

            //assert (lyginam expected su actual output)


            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}




