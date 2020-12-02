using System;
using System.Collections.Generic;
using System.Text;

namespace Day1
{
    public class Day1PartB
    {
        public Tuple<int, int, int> GetNumbersSummingTo2020(List<int> inputList)
        {
            for (int i = 0; i < inputList.Count; i++)
            {
                var remainder = 2020 - inputList[i];

                for (int j = i + 1; j < inputList.Count; j++)
                {
                    if (inputList[j] < remainder)
                    {
                        var finalRemainder = remainder - inputList[j];

                        if (inputList.Contains(finalRemainder))
                        {
                            return Tuple.Create(inputList[i], inputList[j], finalRemainder);
                        }
                    }
                }
            }
            return Tuple.Create(0, 0, 0);
        }
    }
}
