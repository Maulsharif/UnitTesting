using NUnit.Framework;
using System.Collections.Generic;
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

    [TestFixture]
    public class HarryPotterTests
    {
        [Test]
        public void CountDiscountSumTest()
        {
            List<Book> books = DataSource.books;
            Assert.AreEqual(12.4, DiscountCounter.CountDiscountSum(books, 5));
        }
    }
    [TestFixture]
    public class WordWrapperTest
    {
        [Test]
        public void WordWraperTest()
        {
            var characterCount = 4;
            var service = new WordWraper(characterCount);
            var value = "this is a test";
            var expectedResult = "this\n is a t\nest"; 
            var result = service.WordWrap(value);
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void WordWrapperEmptyString()
        {
            var characterCount = 2;
            var service = new WordWraper(characterCount);
            string value = null;
            var expectedResult = string.Empty;  
            var result = service.WordWrap(value);
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void WordWraperNotWrapingString()
        {
            var characterCount = 10;
            var service = new WordWraper(characterCount);
            string value = "test value";
            var expectedResult = "test value";
            var result = service.WordWrap(value);
            Assert.AreEqual(expectedResult, result);
        }

        
    }

}
