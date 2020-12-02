using Day1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Day1Tests
{
    [TestClass]
    public class Day1PartATests
    {
        [TestMethod]
        public void Find2020SumParts_Local()
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

            Day1PartA sut = new Day1PartA();
            var values = sut.GetNumbersSummingTo2020(inputList);
            Assert.AreEqual(2020, values.Item1 + values.Item2);
            Assert.AreEqual(299, values.Item1);
            Assert.AreEqual(1721, values.Item2);
        }

        [TestMethod]
        public void Find2020SumParts_FromFile()
        {
            var filename = @"C:\Users\jock_\source\repos\AdventOfCode2020CS\Day1\input.txt";
            var lines = File.ReadAllLines(filename);
            var inputList = lines.Select(int.Parse).ToList();

            Day1PartA sut = new Day1PartA();
            var values = sut.GetNumbersSummingTo2020(inputList);

            Assert.AreEqual(2020, values.Item1 + values.Item2);
            Assert.AreEqual(399, values.Item1);
            Assert.AreEqual(1621, values.Item2);
        }

        [TestMethod]
        public void SumMatchingParts()
        {
            var value1 = 299;
            var value2 = 1721;

            var result = new Day1PartA().SumMatchingEntries(value1, value2);
            Assert.AreEqual(514579, result);
        }

        [TestMethod]
        public void SumMatchingParts_File ()
        {
            var value1 = 399;
            var value2 = 1621;

            var result = new Day1PartA().SumMatchingEntries(value1, value2);
            Assert.AreEqual(646779, result);
        }
    }
}
