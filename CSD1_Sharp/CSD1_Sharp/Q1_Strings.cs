using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CSD1_Sharp
{
    [TestFixture]
    public class Q1_Strings
    {
        string s1, s2, s3;

        [SetUp]
        public void Init()
        {
            s1 = string.Format("{0}{1}", "abc", "cba");
            s2 = "abc" + "cba";
            s3 = "abccba";
        }

        [Test]
        public void Test1()
        {
            Assert.IsTrue(s1 == s2);
        }

        [Test]
        public void Test2()
        {
            Assert.IsTrue((object)s1 == (object)s2);
        }

        [Test]
        public void Test3()
        {
            Assert.IsTrue(s2 == s3);
        }

        [Test]
        public void Test4()
        {
            Assert.IsTrue((object)s2 == (object)s3);
        }
    }
}
