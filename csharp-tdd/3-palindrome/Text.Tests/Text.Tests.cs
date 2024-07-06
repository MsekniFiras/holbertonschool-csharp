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
        public void EmptyString()
        {
            var test =  "";
            var res = Str.IsPalindrome(test);
            Assert.IsTrue(res);
        }
        [Test]
        [TestCase("Racecar")]
        [TestCase("racecar")]
        [TestCase("A man, a plan, a canal: Panama.")]
        public void isTruePalindrom(string name)
        {
            var res = Str.IsPalindrome(name);
            Assert.IsTrue(res);
        }
        [Test]
        [TestCase("azuyfbhazb")]
        [TestCase("dfzefzegz")]
        [TestCase("kutjyhrtegre")]
        public void isNotPalindrom(string text)
        {
            var res = Str.IsPalindrome(text);
            Assert.IsFalse(res);
        }
    }
}
