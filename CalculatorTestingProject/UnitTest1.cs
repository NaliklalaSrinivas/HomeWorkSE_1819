using CalculatorLibr;
using VasuExternalLibraryForExercise10;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorTestingProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AdditionTestCase()
        {
            BetterCalculator cal = new BetterCalculator();
            var ActuallData = cal.Add(10, 20);
            var PreditedData = 30;
            Assert.AreEqual(ActuallData, PreditedData);
        }

        [TestMethod]
        public void NameTesting()
        {
            NameReturn n = new NameReturn();
            var actuallName = n.names();
            Console.WriteLine("actuallName for the project - "+actuallName);
            var PredictedName = "Srinivas Nalikala 1063567";
            Console.WriteLine("PredictedName for Testing - " + PredictedName);
            Assert.AreNotEqual(actuallName, PredictedName);
        }
    }
}
