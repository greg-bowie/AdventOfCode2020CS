using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Day2
{
    public class Day2PartA
    {
        public int GetCountOfInvalidPasswords(List<string> inputList)
        {
            var invalidCounter = 0;
            foreach (var entry in inputList)
            {
                var comps = entry.Split(' ');
                var occurances = comps[0].Split('-');

                int minOccurances = Int16.Parse(occurances[0]);
                int maxOccurances = Int16.Parse(occurances[1]);
                char requiredChar = comps[1][0];
                var password = comps[2];
                int charAppears = password.Count(c => c == requiredChar);

                if (!((charAppears >= minOccurances) && (charAppears <= maxOccurances)))
                {
                    invalidCounter++;
                }
            }

            return invalidCounter;
        }
    }
}
