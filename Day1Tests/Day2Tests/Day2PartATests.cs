using Day1.Day2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Tests.Day2Tests
{
    [TestClass]
    public class Day2PartATests
    {
        [TestMethod]
        public void DetectedInvalidPasswords_List()
        {
            List<string> inputList = new List<string>()
            {
                "1-3 a: abcde",
                "1-3 b: cdefg",
                "2-9 c: ccccccccc"
            };

            var invalidPasswordEntries = new Day2PartA().GetCountOfInvalidPasswords(inputList);

            Assert.AreEqual(1, invalidPasswordEntries);
        }

        [TestMethod]
        public void DetectedInvalidPasswords_File()
        {
            var filename = @"C:\Users\jock_\source\repos\AdventOfCode2020CS\Day1\Day2\input.txt";
            var lines = File.ReadAllLines(filename).ToList();

            var invalidPasswordEntries = new Day2PartA().GetCountOfInvalidPasswords(lines);

            Assert.AreEqual(500, invalidPasswordEntries);
        }
    }
}
