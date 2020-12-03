using Day1.Day3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Tests.Day3Tests
{
    [TestClass]
    public class Day3PartATests
    {
        [TestMethod]
        public void SampleInputTest()
        {
            // Example Input
            var inputMap = new List<string>()
            {
                "..##.......",
                "#...#...#..",
                ".#....#..#.",
                "..#.#...#.#",
                ".#...##..#.",
                "..#.##.....",
                ".#.#.#....#",
                ".#........#",
                "#.##...#...",
                "#...##....#",
                ".#..#...#.#"
            };

            var numberOfTreesHit = new Day3PartA().GetNumberOfHits(inputMap, 3, 1);

            Assert.AreEqual(7, numberOfTreesHit);
        }

        [TestMethod]
        public void FileInputTest()
        {
            var filename = @"C:\Users\jock_\source\repos\AdventOfCode2020CS\Day1\Day3\input.txt";
            var inputMap = File.ReadAllLines(filename).ToList();

            var numberOfTreesHit = new Day3PartA().GetNumberOfHits(inputMap, 3, 1);

            Assert.AreEqual(242, numberOfTreesHit);
        }

    }
}
