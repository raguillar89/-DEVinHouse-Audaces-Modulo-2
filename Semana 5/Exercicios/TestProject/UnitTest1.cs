using Exercicios;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestReverse()
        {
            var listTest = new List<int> { 1, 2, 3, 4, 5 };
            var listExpected = new List<int> { 5, 4, 3, 2, 1 };

            var result = Metodos.ReverseArray(listTest);

            Assert.AreEqual(result, listExpected);
        }

        [Test]
        public void TestSort()
        {
            var listTest = new List<int> { 2, 8, 1, 0, 6, 10, -1, -6 };
            var listExpected = new List<int> { -6, -1, 0, 1, 2, 6, 8, 10 };

            var result = Metodos.OrderArray(listTest);

            Assert.AreEqual(result, listExpected);
        }

        [Test]
        public void TestSum()
        {
            var listTest = new List<int> { -6, 7, 8, 9, 10 };
            var sumTest = 0;

            var listExpected = new List<int> { -7, 8, 8, 9, 10 };
            var sumExpected = 0;

            var resultTest = Metodos.Sum(sumTest, listTest);
            var resultExpected = Metodos.Sum(sumExpected, listExpected);
            Console.WriteLine(resultTest);
            Console.WriteLine(resultExpected);

            Assert.AreEqual(resultTest, resultExpected);
        }
    }
}