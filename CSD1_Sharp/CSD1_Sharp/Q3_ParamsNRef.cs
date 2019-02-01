using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CSD1_Sharp
{
    [TestFixture]
    public class Q3_ParamsNRef
    {
        void F1(int x)
        {
            x = 10;
        }

        [Test]
        public void Test1()
        {
            int x = 20;
            F1(x);
            Assert.AreEqual(20, x);
        }

        void F2(ref int x)
        {
            x = 10;
        }

        [Test]
        public void Test2()
        {
            int x = 20;
            F2(ref x);
            Assert.AreEqual(20, x);
        }       
        
        void F3(out int x)
        {
            x = 10;
        }

        [Test]
        public void Test3()
        {             
            int x = 20;
            F3(out x);
            Assert.AreEqual(20, x);
        }
    
        //Добавить массив с изменением ячейки внутри метода
        int F4(params int[] x)
        {
            return x.Sum();
        }

        [Test]
        public void Test4()
        {
            Assert.AreEqual(10, F4(10, 20, 30));
        }  
    }
}
