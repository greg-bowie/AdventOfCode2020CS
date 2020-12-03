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
    public class Day3PartBTests
    {
        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(3, 1, 7)]
        [DataRow(5, 1, 3)]
        [DataRow(7, 1, 4)]
        [DataRow(1, 2, 2)]
        public void ExampleMultipleRuns(int moveX, int moveY, int expectedHits)
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

            var numberOfTreesHit = new Day3PartA().GetNumberOfHits(inputMap, moveX, moveY);

            Assert.AreEqual(expectedHits, numberOfTreesHit);
        }

        [DataTestMethod]
        [DataRow(1, 1, 82)]
        [DataRow(3, 1, 242)]
        [DataRow(5, 1, 71)]
        [DataRow(7, 1, 67)]
        [DataRow(1, 2, 24)]
        public void FileInputMultipleRuns(int moveX, int moveY, int expectedHits)
        {
            var filename = @"C:\Users\jock_\source\repos\AdventOfCode2020CS\Day1\Day3\input.txt";
            var inputMap = File.ReadAllLines(filename).ToList();

            var numberOfTreesHit = new Day3PartA().GetNumberOfHits(inputMap, moveX, moveY);

            Assert.AreEqual(expectedHits, numberOfTreesHit);
        }

        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(3, 1, 7)]
        [DataRow(5, 1, 3)]
        [DataRow(7, 1, 4)]
        [DataRow(1, 2, 2)]
        public void ExampleMultipleRunsAlgo(int moveX, int moveY, int expectedHits)
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

            var numberOfTreesHit = new Day3PartA().GetNumberOfHitsAlgorithm(inputMap, moveX, moveY);

            Assert.AreEqual(expectedHits, numberOfTreesHit);
        }

        [DataTestMethod]
        [DataRow(1, 1, 82)]
        [DataRow(3, 1, 242)]
        [DataRow(5, 1, 71)]
        [DataRow(7, 1, 67)]
        [DataRow(1, 2, 24)]
        public void FileInputMultipleRunsAlgo(int moveX, int moveY, int expectedHits)
        {
            var filename = @"C:\Users\jock_\source\repos\AdventOfCode2020CS\Day1\Day3\input.txt";
            var inputMap = File.ReadAllLines(filename).ToList();

            var numberOfTreesHit = new Day3PartA().GetNumberOfHitsAlgorithm(inputMap, moveX, moveY);

            Assert.AreEqual(expectedHits, numberOfTreesHit);
        }
    }
}
