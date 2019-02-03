﻿using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace CSharpExam
{
    [TestFixture]
    public class Question_yield
    {
        List<string> checkpoints1, checkpoints2;

        IEnumerable<string> _fizzbuzz(List<string> checkpoints)
        {
            checkpoints.Add("A");
            yield return "fizz";
            checkpoints.Add("B");
            yield return "buzz";
            checkpoints.Add("C");
        }

        [SetUp]
        public void TestInit()
        {
            checkpoints1 = new List<string>();
            foreach (string value in _fizzbuzz(checkpoints1))
                checkpoints1.Add(value);

            checkpoints2 = new List<string>();
            checkpoints2.AddRange(_fizzbuzz(checkpoints2));
        }


        [Test]
        public void Answer1()
        {
            CollectionAssert.AreEqual(new[] { "A", "fizz", "B", "buzz", "C" }, checkpoints1);
            CollectionAssert.AreEqual(checkpoints1, checkpoints2);
        }

        [Test]
        public void Answer2()
        {
            CollectionAssert.AreEqual(new[] { "A", "B", "C", "fizz", "buzz" }, checkpoints1);
            CollectionAssert.AreEqual(checkpoints1, checkpoints2);
        }

        [Test]
        public void Answer3()
        {
            CollectionAssert.AreEqual(new[] { "A", "fizz", "B", "buzz", "C" }, checkpoints1);
            CollectionAssert.AreNotEqual(checkpoints1, checkpoints2);
        }

        [Test]
        public void Answer4()
        {
            CollectionAssert.AreEqual(new[] { "A", "B", "C", "fizz", "buzz" }, checkpoints1);
            CollectionAssert.AreNotEqual(checkpoints1, checkpoints2);
        }
    }
}
