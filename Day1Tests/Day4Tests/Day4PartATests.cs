using Day1.Day4;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Tests.Day4Tests
{
    [TestClass]
    public class Day4PartATests
    {
        [TestMethod]
        public void ExampleInputTest()
        {
            var inputFileContentsList = new List<string>()
            {
                "ecl:gry pid:860033327 eyr:2020 hcl:#fffffd",
                "byr:1937 iyr:2017 cid:147 hgt: 183cm",
                "",
                "iyr:2013 ecl:amb cid:350 eyr:2023 pid:028048884",
                "hcl:#cfa07d byr:1929",
                "",
                "hcl:#ae17e1 iyr:2013",
                "eyr:2024",
                "ecl:brn pid:760753108 byr:1931",
                "hgt:179cm",
                "",
                "hcl:#cfa07d eyr:2025 pid:166559648",
                "iyr:2011 ecl:brn hgt:59in"
            };

            var numberOfValidPassports = new Day4PartA().GetNumberOfValidPassports(inputFileContentsList);

            Assert.AreEqual(2, numberOfValidPassports);
        }

        [TestMethod]
        public void FileInputTest()
        {
            var filename = @"C:\Users\jock_\source\repos\AdventOfCode2020CS\Day1\Day4\input.txt";
            var inputFileContentsList = File.ReadAllLines(filename).ToList();

            var numberOfValidPassports = new Day4PartA().GetNumberOfValidPassports(inputFileContentsList);

            Assert.AreEqual(147, numberOfValidPassports);
        }
    }
}
