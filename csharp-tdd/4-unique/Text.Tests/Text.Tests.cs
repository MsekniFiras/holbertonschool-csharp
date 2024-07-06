using NUnit.Framework;
using Text;
namespace Text.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void TestNull()
        {
            Assert.AreEqual(-1, Text.Str.UniqueChar(null));
        }
        [Test]
        public void TestRepeating()
        {
            var res = Str.UniqueChar("abzed");
            Assert.AreEqual(res, 0);
        }
        [Test]
        public void test_2()
        {
            var res = Str.UniqueChar("aaaazeee");
            Assert.AreEqual(res, 4);
        }
        [Test]
        public void test_3()
        {
            var res = Str.UniqueChar("aaaaaaaaa");
            Assert.AreEqual(res,-1);
        }
    }
}
