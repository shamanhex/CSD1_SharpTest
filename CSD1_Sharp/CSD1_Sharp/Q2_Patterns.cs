using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CSD1_Sharp
{
    [TestFixture]
    public class Q2_Patterns
    {                       
        int Square(int x = 10)
        {
            return x * x;
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(100, this.Square());
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(0, this.Square(0));
        }
        

    }
}
