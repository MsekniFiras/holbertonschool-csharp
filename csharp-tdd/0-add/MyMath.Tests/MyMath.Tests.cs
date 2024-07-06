using NUnit.Framework;

namespace MyMath.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(68,1)]
        [TestCase(60,9)]
        [TestCase(58,11)]
        [TestCase(100,-31)]
        [TestCase(69,0)]

        public void Test1(int val1, int val2)
        {
            var res = MyMath.Operations.Add(val1, val2);
            Assert.AreEqual(69, res);
        }
    }
}
