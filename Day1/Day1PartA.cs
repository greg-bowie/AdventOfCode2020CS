using System;
using System.Collections.Generic;
using System.Text;

namespace Day1
{
    public class Day1PartA
    {
        public Tuple<int, int> GetNumbersSummingTo2020(List<int> inputList)
        {
            // Sort list
            // do loop for front and back, and bail-out when sum is less than 2020
            inputList.Sort();

            for (int i = 0; i < inputList.Count; i++)
            {
                var remainder = 2020 - inputList[i];

                if (inputList.Contains(remainder))
                {
                    if (remainder < inputList[i])
                    {
                        return Tuple.Create(remainder, inputList[i]);
                    }
                    return Tuple.Create(inputList[i], remainder);
                }
            }
            return Tuple.Create(0, 0);
        }

        // Sorted: Takes 6-10 ms for file list
        public Tuple<int, int> GetNumbersSummingTo2020_Sorted(List<int> inputList)
        {
            // Sort list
            // do loop for front and back, and bail-out when sum is less than 2020
            inputList.Sort();

            for (int i = 0; i < inputList.Count; i++)
            {
                for (int j = inputList.Count - 1; j >= 0; j--)
                {
                    var tempResult = inputList[i] + inputList[j];
                    if (tempResult == 2020)
                    {
                        return Tuple.Create(inputList[i], inputList[j]);
                    }
                    else if (tempResult < 2020)
                    {
                        break;
                    }
                }
            }
            return Tuple.Create(0, 0);
        }

        // Takes 8-9 ms for file list
        public Tuple<int, int> GetNumbersSummingTo2020_Dirty(List<int> inputList)
        {
            for (int i = 0; i < inputList.Count; i++)
            {
                for (int j = i + 1; j < inputList.Count; j++)
                {
                    if (inputList[i] + inputList[j] == 2020)
                    {
                        if (inputList[i] < inputList[j])
                        {
                            return Tuple.Create(inputList[i], inputList[j]);
                        }
                        return Tuple.Create(inputList[j], inputList[i]);
                    }
                }
            }
            return Tuple.Create(0, 0);
        }

        public int SumMatchingEntries(int value1, int value2)
        {
            return value1 * value2;
        }
    }
}
