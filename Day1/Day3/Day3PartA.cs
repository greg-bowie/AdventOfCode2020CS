using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Day3
{
    public class Day3PartA
    {
        public int GetNumberOfHits(List<string> inputMap, int moveX, int moveY)
        {
            var numberOfHits = 0;
            var currentX = 0;
            var currentY = 0;

            var numberOfLines = inputMap.Count;

            for (int i = 0; i < numberOfLines - 1; i = i + moveY)
            {
                currentX += moveX;
                currentY += moveY;

                var mapLine = inputMap[currentY];

                if (currentX >= mapLine.Length)
                {
                    currentX -= mapLine.Length;
                }

                if (mapLine[currentX] == '#')
                {
                    numberOfHits++;
                }
            }

            return numberOfHits;
        }
    }
}
