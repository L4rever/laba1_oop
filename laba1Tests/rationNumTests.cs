using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass]
    public class rationNumTests
    {
        [TestMethod]
        public void Constructor_ShouldReduceFraction()
        {
            var r = new rationNum(5, 10);
            Assert.AreEqual(1, r.Numerator);
            Assert.AreEqual(2, r.Denominator);
        }

        [TestMethod]
        public void Constructor_ShouldThrowOnZeroDenominator()
        {
            Assert.ThrowsException<ArgumentException>(() => new rationNum(1, 0));
        }

        [TestMethod]
        public void ToString_ShouldReturnIntegerIfDenominatorIsOne()
        {
            var r = new rationNum(4, 2); // сокращается до 2/1
            Assert.AreEqual("2", r.ToString());
        }

        [TestMethod]
        public void ToString_ShouldReturnFractionIfDenominatorIsNotOne()
        {
            var r = new rationNum(3, 4);
            Assert.AreEqual("3/4", r.ToString());
        }

        [TestMethod]
        public void NegativeSign_ShouldBeInNumeratorOnly()
        {
            var r1 = new rationNum(-1, 2);
            var r2 = new rationNum(1, -2);
            var r3 = new rationNum(-1, -2);

            Assert.AreEqual("-1/2", r1.ToString());
            Assert.AreEqual("-1/2", r2.ToString());
            Assert.AreEqual("1/2", r3.ToString());
        }

        [TestMethod]
        public void Addition_ShouldWorkCorrectly()
        {
            var a = new rationNum(1, 3);
            var b = new rationNum(1, 6);
            var result = a + b;

            Assert.AreEqual("1/2", result.ToString());
        }

        [TestMethod]
        public void Subtraction_ShouldWorkCorrectly()
        {
            var a = new rationNum(2, 3);
            var b = new rationNum(1, 6);
            var result = a - b;

            Assert.AreEqual("1/2", result.ToString());
        }

        [TestMethod]
        public void Multiplication_ShouldWorkCorrectly()
        {
            var a = new rationNum(2, 3);
            var b = new rationNum(3, 4);
            var result = a * b;

            Assert.AreEqual("1/2", result.ToString());
        }

        [TestMethod]
        public void Division_ShouldWorkCorrectly()
        {
            var a = new rationNum(1, 2);
            var b = new rationNum(1, 4);
            var result = a / b;

            Assert.AreEqual("2", result.ToString());
        }

        [TestMethod]
        public void Division_ByZeroNumerator_ShouldThrow()
        {
            var a = new rationNum(1, 2);
            var b = new rationNum(0, 1);

            Assert.ThrowsException<DivideByZeroException>(() => a / b);
        }

        [TestMethod]
        public void UnaryMinus_ShouldWork()
        {
            var a = new rationNum(1, 2);
            var result = -a;

            Assert.AreEqual("-1/2", result.ToString());
        }

        [TestMethod]
        public void Equality_ShouldWork()
        {
            var a = new rationNum(1, 2);
            var b = new rationNum(2, 4);
            Assert.IsTrue(a == b);
        }

        [TestMethod]
        public void Inequality_ShouldWork()
        {
            var a = new rationNum(1, 2);
            var b = new rationNum(3, 4);
            Assert.IsTrue(a != b);
        }

        [TestMethod]
        public void ComparisonOperators_ShouldWork()
        {
            var a = new rationNum(1, 3);
            var b = new rationNum(1, 2);

            Assert.IsTrue(a < b);
            Assert.IsTrue(b > a);
            Assert.IsTrue(a <= b);
            Assert.IsTrue(b >= a);
        }
    }
}