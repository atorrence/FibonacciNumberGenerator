using Microsoft.VisualStudio.TestTools.UnitTesting;
using FibonacciNumberGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumberGenerator.Models.Tests
{
    [TestClass()]
    public class ResultTests
    {
        [TestMethod()]
        public void GetFibonacciSequenceTestwith14()
        {
            Result r = new Result();
            r.InputNumber = 14;
            Assert.AreEqual(377, r.GetFibonacciSequence());
        }

        [TestMethod()]
        public void GetFibonacciSequenceTestwith78()
        {
            Result r = new Result();
            r.InputNumber = 52;
            Assert.AreEqual(32951280099, r.GetFibonacciSequence());
        }

        [TestMethod()]
        public void GetFibonacciSequenceTestwith0()
        {
            Result r = new Result();
            r.InputNumber = 0;
            Assert.AreEqual(0, r.GetFibonacciSequence());
        }

        [TestMethod()]
        public void GetFibonacciSequenceTestwith1()
        {
            Result r = new Result();
            r.InputNumber = 1;
            Assert.AreEqual(0, r.GetFibonacciSequence());
        }
        [TestMethod()]
        public void GetFibonacciSequenceTestwith92()
        {
            Result r = new Result();
            r.InputNumber = 92;
            Assert.AreEqual(7540113804746346429, r.GetFibonacciSequence());
        }

    }
}