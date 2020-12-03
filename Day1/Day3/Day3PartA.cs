using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Day3
{
    public class Day3PartA
    {
        // 604.2 nanoseconds
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

        // 5.556 microseconds.
        public int GetNumberOfHitsAlgorithm(List<string> inputMap, int moveX, int moveY)
        {
            var numberOfHits = 0;
            var currentX = 0;
            var currentY = 0;

            // Assuming same line length throughout!
            MapCoords.LineLength = inputMap[0].Length;

            var numberOfLines = inputMap.Count;

            for (int i = 0; i < numberOfLines - 1; i = i + moveY)
            {
                currentX += moveX;
                currentY += moveY;
                var newMapCoords = new MapCoords(currentX, currentY);

                if (inputMap[newMapCoords.YPos][newMapCoords.XPos] == '#')
                {
                    numberOfHits++;
                }
            }

            return numberOfHits;
        }

    }
}
