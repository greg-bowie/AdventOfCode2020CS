using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Day5
{
    public class Day5PartA
    {
        public int GetSeatId(string input)
        {
            var row = GetRow(input.Substring(0, 7));
            var column = GetColumn(input.Substring(7));

            return (row * 8) + column;
        }

        public int GetRow(string input)
        {
            int lowerBound = 0;
            int upperBound = 127;

            for (int i = 0; i < input.Length; i++)
            {
                var diff = (upperBound - lowerBound + 1) / 2;

                if (input[i] == 'F')
                {
                    upperBound -= diff;
                }
                else
                {
                    lowerBound += diff;
                }
            }

            if (input[6] == 'F')
            {
                return lowerBound;
            }
            return upperBound;
        }

        public int GetColumn(string input)
        {
            int lowerBound = 0;
            int upperBound = 7;

            for (int i = 0; i < input.Length; i++)
            {
                var diff = (upperBound - lowerBound + 1) / 2;

                if (input[i] == 'L')
                {
                    upperBound -= diff;
                }
                else
                {
                    lowerBound += diff;
                }
            }

            if (input[2] == 'L')
            {
                return lowerBound;
            }
            return upperBound;
        }

        public int MissingSeatId(List<int> seatInput)
        {
            var lowestSeatId = seatInput.Min();
            var highestSeatId = seatInput.Max();

            var missingSeatIds = Enumerable.Range(lowestSeatId, highestSeatId).Except(seatInput);

            return missingSeatIds.ElementAt(0);
        }
    }
}
