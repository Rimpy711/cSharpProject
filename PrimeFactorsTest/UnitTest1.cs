using Microsoft.VisualStudio.TestTools.UnitTesting;
using cSharpPrime;
namespace PrimeFactorsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            int number = 6;

            // Act
            string expected = "2*3";
            string res = Program.PrimeFactors(number);

            // Assert
            Assert.AreEqual(expected, res);


        }
        public void TestMethod2()
        {
            // Arrange
            int number = 30;

            // Act
            string expected = "2*3*5";
            string res = Program.PrimeFactors(number);

            // Assert
            Assert.AreEqual(expected, res);


        }

    }
}
