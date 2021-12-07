using NUnit.Framework;
using UnitTesting;
namespace Tests
{
    [TestFixture]
    public class OddEvenTests
    {
        [TestCase(0, ExpectedResult = false)]
        [TestCase(1, ExpectedResult = false)]
        [TestCase(2, ExpectedResult = true)]
        [TestCase(29, ExpectedResult = false)]
        [TestCase(66, ExpectedResult = true)]
        [TestCase(21, ExpectedResult = false)]
        public bool IsEvenTest(int num)
        {
            return OddEven.IsEven(num);
        }
        [TestCase(0, ExpectedResult = false)]
        [TestCase(1, ExpectedResult = true)]
        [TestCase(2, ExpectedResult = false)]
        [TestCase(29, ExpectedResult = false)]
        [TestCase(66, ExpectedResult = false)]
        [TestCase(21, ExpectedResult = true)]
        [TestCase(555, ExpectedResult = true)]
        public bool IsOddTest(int num)
        {
            return OddEven.IsOdd(num);
        }
        [TestCase(0, ExpectedResult = false)]
        [TestCase(1, ExpectedResult = false)]
        [TestCase(2, ExpectedResult = true)]
        [TestCase(29, ExpectedResult = true)]
        [TestCase(55, ExpectedResult = false)]
        [TestCase(21, ExpectedResult = false)]
        [TestCase(429, ExpectedResult = false)]
        [TestCase(283, ExpectedResult = true)]
        public bool IsPrimeTest(int num)
        {
            return OddEven.IsPrime(num);
        }
        
        [Test]
        public void GenerateNumbersTests()
        {
            int[] arr = OddEven.GenerateNumbers(1, 10, 10);
            Assert.AreEqual(arr.Length, 10);
            for (int i = 0; i < arr.Length; i++)
            {
                Assert.IsTrue(arr[i] >= 1 || arr[i] <= 10);
            }
        }
    }
}