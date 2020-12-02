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
    public class Day2PartBTests
    {
        [TestMethod]
        public void DetectedValidPasswords_List()
        {
            List<string> inputList = new List<string>()
            {
                "1-3 a: abcde",
                "1-3 b: cdefg",
                "2-9 c: ccccccccc"
            };

            var validPasswordEntries = new Day2PartB().GetCountOfValidPasswords(inputList);

            Assert.AreEqual(1, validPasswordEntries);
        }

        [TestMethod]
        public void DetectedValidPasswords_File()
        {
            var filename = @"C:\Users\jock_\source\repos\AdventOfCode2020CS\Day1\Day2\input.txt";
            var lines = File.ReadAllLines(filename).ToList();

            var validPasswordEntries = new Day2PartB().GetCountOfValidPasswords(lines);

            Assert.AreEqual(313, validPasswordEntries);
        }
    }
}
