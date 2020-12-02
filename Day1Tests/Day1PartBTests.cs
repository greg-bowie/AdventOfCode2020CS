using Day1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Day1Tests
{
    [TestClass]
    public class Day1PartBTests
    {
        [TestMethod]
        public void Find3NumbersToSumTo2020_List()
        {
            List<int> inputList = new List<int>
            {
                1721,
                979,
                366,
                299,
                675,
                1456
            };

            var sut = new Day1PartB();
            var values = sut.GetNumbersSummingTo2020(inputList);

            Assert.AreEqual(2020, values.Item1 + values.Item2 + values.Item3);
            Assert.AreEqual(979, values.Item1);
            Assert.AreEqual(366, values.Item2);
            Assert.AreEqual(675, values.Item3);
        }

        [TestMethod]
        public void Find3NumbersToSumTo2020_File()
        {
            var filename = @"C:\Users\jock_\source\repos\AdventOfCode2020CS\Day1\input.txt";
            var lines = File.ReadAllLines(filename);
            var inputList = lines.Select(int.Parse).ToList();

            var sut = new Day1PartB();
            var values = sut.GetNumbersSummingTo2020(inputList);

            Assert.AreEqual(2020, values.Item1 + values.Item2 + values.Item3);
            Assert.AreEqual(591, values.Item1);
            Assert.AreEqual(1021, values.Item2);
            Assert.AreEqual(408, values.Item3);
        }
    }
}
