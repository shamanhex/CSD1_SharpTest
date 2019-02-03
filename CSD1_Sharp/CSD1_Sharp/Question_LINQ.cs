using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace CSharpExam
{
    [TestFixture]
    public class Question_LINQ
    {
        List<int> numbers;
        IEnumerable<int> odd_numbers1;

        [SetUp]
        public void TestInit()
        {
            numbers = new List<int>() { 0, 1, 2, 3, 4 };

            odd_numbers1 = from n in numbers
                           where n % 2 == 0
                           select n;
        }

        [Test]
        public void Test1()
        {
            CollectionAssert.AreEqual(new []{ 0, 2, 4 }, odd_numbers1.ToList());
        }

        [Test]
        public void Test2()
        {
            numbers.Remove(2);
            CollectionAssert.AreEqual(new []{ 0, 2, 4 }, odd_numbers1.ToList());
        }

        [Test]
        public void Test3()
        {
            IEnumerable<int> odd_numbers2 = odd_numbers1.Where(n => n > 0);
            numbers.Remove(2);

            CollectionAssert.AreEqual(new []{ 0, 4 }, odd_numbers1.ToList());
            CollectionAssert.AreEqual(new []{ 2, 4 }, odd_numbers2.ToList());
        }
        
        [Test]
        public void Test4()
        {
            IEnumerable<int> odd_numbers2 = odd_numbers1.Where(n => n > 0).ToList();
            numbers.Remove(2);

            CollectionAssert.AreEqual(new[] { 0, 4 }, odd_numbers1.ToList());
            CollectionAssert.AreEqual(new[] { 2, 4 }, odd_numbers2.ToList());
        }

    }
}
