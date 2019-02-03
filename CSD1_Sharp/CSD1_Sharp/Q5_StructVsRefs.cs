using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSD1_Sharp
{
    class C : IDisposable
    {
        public bool Disposed { get; set; }
        public void Dispose() { Disposed = true; }
    }

    struct S : IDisposable
    {
        public bool Disposed { get; set; }
        public void Dispose() { Disposed = true; }
    }


    [TestFixture]
    public class Q5_StructVsRefs
    {
        void OuterDispose(C c)
        {
            c.Disposed = true;
        }

        void OuterDispose(S s)
        {
            s.Disposed = true;
        }


        [Test]
        public void Test1()
        {
            var c = new C();
            OuterDispose(c);
            var s = new S();
            OuterDispose(s);
            Assert.IsTrue(c.Disposed);
            Assert.IsTrue(s.Disposed);
        }

        [Test]
        public void Test2()
        {
            var c = new C();
            var other_c = c;
            c.Dispose();
            Assert.IsTrue(other_c.Disposed);

            var s = new S();
            var other_s = s;
            s.Dispose();
            Assert.IsTrue(other_s.Disposed);
        }

        [Test]
        public void Test3()
        {
            var c = new C();
            using (c) { /*nothing to do*/ }
            Assert.IsTrue(c.Disposed);

            var s = new S();
            using (s) { /* nothing to do */ }
            Assert.IsTrue(s.Disposed);
        }

        [Test]
        public void Test4()
        {
        }

    }
}
