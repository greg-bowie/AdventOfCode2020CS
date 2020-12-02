using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Day2
{
    public class Day2PartB
    {
        public int GetCountOfValidPasswords(List<string> inputList)
        {
            var validCounter = 0;
            foreach (var entry in inputList)
            {
                var comps = entry.Split(' ');
                var occurances = comps[0].Split('-');

                int position1 = Int16.Parse(occurances[0]);
                int position2 = Int16.Parse(occurances[1]);
                char requiredChar = comps[1][0];
                var password = comps[2];

                if ((password[position1 - 1] == requiredChar) ^ (password[position2 - 1] == requiredChar))
                {
                    validCounter++;
                }
            }

            return validCounter;
        }
    }
}
