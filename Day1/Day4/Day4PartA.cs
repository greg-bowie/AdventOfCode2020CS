using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Day4
{
    public class Day4PartA
    {
        public int GetNumberOfValidPassports(List<string> passportFile)
        {
            var validPassportsCount = 0;
            PassportInfo passportInfo = new PassportInfo();

            foreach (var line in passportFile)
            {
                var cleanLine = line.Replace(": ", ":");
                if (line.Trim().Length == 0)
                {
                    if (passportInfo.IsValid())
                    {
                        validPassportsCount++;
                    }

                    // Reset passportInfo.
                    passportInfo = new PassportInfo();
                }
                else
                {
                    string[] comps = new string[1];
                    comps[0] = line;
                    if (line.Contains(' '))
                    {
                        comps = line.Split(' ');
                    }

                    for (int i = 0; i < comps.Length; i++)
                    {
                        string[] keyValuePair = comps[i].Split(':');
                        passportInfo.UpdateInfo(keyValuePair[0], keyValuePair[1]);
                    }
                }
            }

            if (passportInfo.IsValid())
            {
                validPassportsCount++;
            }

            return validPassportsCount;
        }
    }
}
