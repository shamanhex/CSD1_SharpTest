using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace CSharpExam
{
    [TestClass]
    public class Question_LINQ
    {
        IEnumerable<int> odd_numbers1, odd_numbers2;

        [TestInitialize]
        public void TestInit()
        {
            List<int> numbers = new List<int>() { 0, 1, 2, 3, 4 };

            odd_numbers1 = from n in numbers
                           where n % 2 == 0
                           select n;
            odd_numbers2 = odd_numbers1.ToList();
            numbers.Remove(2);
        }

        [TestMethod]
        public void Answer1()
        {
            CollectionAssert.AreEqual(new []{ 0, 2, 4 }, odd_numbers1.ToList());
            CollectionAssert.AreEqual(new []{ 0, 2, 4 }, odd_numbers2.ToList());
        }

        [TestMethod]
        public void Answer2()
        {
            CollectionAssert.AreEqual(new []{ 0, 4 }, odd_numbers1.ToList());
            CollectionAssert.AreEqual(new []{ 0, 2, 4 }, odd_numbers2.ToList());
        }

        [TestMethod]
        public void Answer3()
        {
            CollectionAssert.AreEqual(new []{ 0, 2, 4 }, odd_numbers1.ToList());
            CollectionAssert.AreEqual(new []{ 0, 4 }, odd_numbers2.ToList());
        }

        [TestMethod]
        public void Answer4()
        {
            CollectionAssert.AreEqual(new []{ 0, 4 }, odd_numbers1.ToList());
            CollectionAssert.AreEqual(new []{ 0, 4 }, odd_numbers2.ToList());
        }

    }
}
