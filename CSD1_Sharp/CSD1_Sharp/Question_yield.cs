using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace CSharpExam
{
    [TestFixture]
    public class Question_yield
    {
        IEnumerable<string> _fizzbuzz(List<string> checkpoints)
        {
            checkpoints.Add("A");
            yield return "fizz";
            checkpoints.Add("B");
            yield return "buzz";
            checkpoints.Add("C");
        }


        [Test]
        public void Answer1()
        {
            var checkpoints1 = new List<string>();
            foreach (string value in _fizzbuzz(checkpoints1))
                checkpoints1.Add(value);


            CollectionAssert.AreEqual(new[] { "A", "fizz", "B", "buzz", "C" }, checkpoints1);
        }

        [Test]
        public void Answer2()
        {
            var checkpoints1 = new List<string>();
            checkpoints1.AddRange(_fizzbuzz(checkpoints1));

            CollectionAssert.AreEqual(new[] { "A", "fizz", "B", "buzz", "C" }, checkpoints1);
        }

    }
}
