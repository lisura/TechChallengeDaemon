using DaemonChallengeAPI.Services;
using NUnit.Framework;

namespace DaemonChallengeAPITests.Services
{
    class FactorialCalculatorTests
    {
        [Test]
        public void When_CallCalculateMethodWithNumber_ReturnTheNumberFactorial()
        {
            //Arrange 
            int number1 = 10;
            int number2 = 15;
            int number3 = 20;
            int number4 = 21;

            //Act
            var factorial1 = FactorialCalculator.Calculate(number1);
            var factorial2 = FactorialCalculator.Calculate(number2);
            var factorial3 = FactorialCalculator.Calculate(number3);
            var factorial4 = FactorialCalculator.Calculate(number4);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.AreEqual(3628800, factorial1);
                Assert.AreEqual(1307674368000, factorial2);
                Assert.AreEqual(2432902008176640000, factorial3);
                Assert.AreEqual(14197454024290336768, factorial4);
            });
        }
    }
}
