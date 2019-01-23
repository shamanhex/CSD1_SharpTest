using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CSD1_Sharp
{
    [TestFixture]
    public class Q2_GenericAndDefaults
    {
        bool Eq<T>(object arg1 = null, T arg2 = default(T))   
        {                            
            return Object.Equals(arg1, arg2);
        }

        [Test]
        public void Test1()
        {
            Assert.IsTrue(Eq<int>(1));
        }

        [Test]
        public void Test2()
        {
            Assert.IsTrue(Eq<object>());
        }

        [Test]
        public void Test3()
        {
            Assert.IsTrue(Eq<String>(""));
        }

        [Test]
        public void Test4()
        {
            Assert.IsTrue(Eq<String>());
        }  
    }
}
