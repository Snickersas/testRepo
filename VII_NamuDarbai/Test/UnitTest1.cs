using NUnit.Framework;
using VII_NamuDarbai;

namespace Test
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

            string sakinys = "As esu Vaidotas";
            string expectedResult = "satodiaV use sA";

            //act (callinam metoda)

            var actualResult = Program.SakinioApvertimas(sakinys);

            //assert (lyginam expected su actual output)


            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}