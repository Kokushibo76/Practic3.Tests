using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Practic3;

namespace Practic3Tests
{
    [TestClass]
    public class UnitTest1
    {
        private static readonly double delta = 0.0001;

        private static double[] DLessThanZero = { 1, 2, 5 };
        private static double[] DEqualsZero = { 1, 2, 1 };
        private static double[] DGreaterThanZero = { 1, -3, 2 };

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            context.WriteLine("Инициализация");
        }

        [TestMethod]
        public void Practic3_DEqualsZero_NullRoots()
        {
            double a = DLessThanZero[0];
            double b = DLessThanZero[1];
            double c = DLessThanZero[2];

            var result = Practic.FindRoots(a, b, c);

            Assert.IsNull(result.root1);
            Assert.IsNull(result.root2);
        }

        [TestMethod]
        public void Practic3_DLessThanZero_OneRoot()
        {
            double a = DEqualsZero[0];
            double b = DEqualsZero[1];
            double c = DEqualsZero[2];

            var result = Practic.FindRoots(a, b, c);

            Assert.AreEqual(-1.0, result.root1.GetValueOrDefault(), delta);
            Assert.AreEqual(-1.0, result.root2.GetValueOrDefault(), delta);
        }

        [TestMethod]
        public void Practic3_DGreaterThanZero_TwoRoots()
        {
            double a = DGreaterThanZero[0];
            double b = DGreaterThanZero[1];
            double c = DGreaterThanZero[2];

            var result = Practic.FindRoots(a, b, c);

            Assert.AreEqual(2.0, result.root1.GetValueOrDefault(), delta);
            Assert.AreEqual(1.0, result.root2.GetValueOrDefault(), delta);
        }

        [TestMethod]
        public void Practic3_CalculatePercent_ExpectedResult()
        {
            double number = 200;
            double percent = 15;

            var result = Practic.CalculatePercentage(number, percent);

            Assert.AreEqual(30.0, result, delta);
        }
    }
}