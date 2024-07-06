using NUnit.Framework;

namespace MyMath.Tests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            int[,] mat1 = new int[,] { { 2, 4 }, { 6, 8 }, { 10, 12 }, { 24, 40 } };
            Assert.AreEqual(new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 12, 20 } }, MyMath.Matrix.Divide(mat1, 2));
        }

        [Test]
        public void Test2()
        {
            int[,] mat2 = new int[,] { { 2, 4 }, { 6, 8 }, { 10, 12 }, { 24, 40 } };
            Assert.IsNull(MyMath.Matrix.Divide(mat2, 0));
        }

        [Test]
        public void Test3()
        {
            Assert.IsNull(MyMath.Matrix.Divide(null, 2));
        }
    }
}
