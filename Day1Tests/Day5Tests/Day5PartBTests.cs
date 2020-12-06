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
    public class Day5PartBTests
    {
        [TestMethod]
        public void FindMissingSeatId()
        {
            var filename = @"C:\Users\jock_\source\repos\AdventOfCode2020CS\Day1\Day5\input.txt";
            var inputList = File.ReadAllLines(filename).ToList();

            var seatIdList = new List<int>();
            var processor = new Day5PartA();

            foreach (var item in inputList)
            {
                seatIdList.Add(processor.GetSeatId(item));
            }

            var missingSeatId = processor.MissingSeatId(seatIdList);
            Assert.AreEqual(619, missingSeatId);
            /*seatIdList.Sort();

            var previous = 0;

            foreach (var seatId in seatIdList)
            {
                var expected = previous + 1;

                if (seatId != expected && previous != 0)
                {
                    Assert.AreEqual(619, seatId - 1);
                }

                previous = seatId;
            }*/
        }
    }
}
