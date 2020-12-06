using Day1.Day5;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Tests.Day5Tests
{
    [TestClass]
    public class Day5PartATests
    {
        [DataTestMethod]
        [DataRow("FBFBBFFRLR", 357)]
        [DataRow("BFFFBBFRRR", 567)]
        [DataRow("FFFBBBFRRR", 119)]
        [DataRow("BBFFBBFRLL", 820)]
        public void GetSeatId(string input, int expectedSeatId)
        {
            var seatId = new Day5PartA().GetSeatId(input);

            Assert.AreEqual(expectedSeatId, seatId);
        }

        [TestMethod]
        public void GetSeatIdViaFile()
        {
            var filename = @"C:\Users\jock_\source\repos\AdventOfCode2020CS\Day1\Day5\input.txt";
            var inputList = File.ReadAllLines(filename).ToList();

            var highestSeatId = 0;

            foreach (var item in inputList)
            {
                var seatId = new Day5PartA().GetSeatId(item);

                if (seatId > highestSeatId)
                {
                    highestSeatId = seatId;
                }
            }


            Assert.AreEqual(908, highestSeatId);
        }

        [DataTestMethod]
        [DataRow("FBFBBFF", 44)]
        [DataRow("BFFFBBF", 70)]
        [DataRow("FFFBBBF", 14)]
        [DataRow("BBFFBBF", 102)]
        public void TestForRows(string input, int expectedRowId)
        {
            var rowId = new Day5PartA().GetRow(input);

            Assert.AreEqual(expectedRowId, rowId);
        }

        [DataTestMethod]
        [DataRow("RLR", 5)]
        [DataRow("RRR", 7)]
        [DataRow("RRR", 7)]
        [DataRow("RLL", 4)]
        public void TestForColumns(string input, int expectedColumnId)
        {
            var rowId = new Day5PartA().GetColumn(input);

            Assert.AreEqual(expectedColumnId, rowId);
        }

    }
}
