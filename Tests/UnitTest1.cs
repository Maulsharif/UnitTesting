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
    }
}