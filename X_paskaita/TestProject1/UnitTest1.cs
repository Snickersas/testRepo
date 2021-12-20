using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FullNameTestValid()
        {
            //Arrange

            var customer = new Customer();
            customer.FirstName = "Jonas";
            customer.LastName = "Jonauskas";

            string expectedValue = "Jonauskas, Jonas";

            //Act
            string actualValue = customer.GetFullName();
            
            //Assert

            Assert.AreEqual(expectedValue, actualValue);

        }
    }
}