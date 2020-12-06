using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Day4
{
    public class PassportInfo
    {
        private Dictionary<string, string> PassportDictionary;
        private readonly List<string> ValidKeys = new List<string>()
        {
            "byr", "iyr", "eyr", "hgt", "hcl", "ecl", "pid"
        };
        private readonly List<string> ValidEyeColourList = new List<string>()
        {
            "amb", "blu", "brn", "gry", "grn", "hzl", "oth"
        };

        public PassportInfo()
        {
            PassportDictionary = new Dictionary<string, string>();
        }

        public void UpdateInfo(string key, string value)
        {
            if (ValidKeys.Contains(key))
            {
                switch (key)
                {
                    case "byr":
                        int tempBirthYear = Int16.Parse(value);
                        if (tempBirthYear >= 1920 && tempBirthYear <= 2002)
                        {
                            PassportDictionary.Add(key, value);
                        }
                        break;

                    case "iyr":
                        int tempIssueYear = Int16.Parse(value);
                        if (tempIssueYear >= 2010 && tempIssueYear <= 2020)
                        {
                            PassportDictionary.Add(key, value);
                        }
                        break;

                    case "eyr":
                        int tempExpiryYear = Int16.Parse(value);
                        if (tempExpiryYear >= 2020 && tempExpiryYear <= 2030)
                        {
                            PassportDictionary.Add(key, value);
                        }
                        break;

                    case "hgt":
                        if (value.ToLower().EndsWith("cm"))
                        {
                            var tempValue = value.Replace("cm", "");
                            int height = Int16.Parse(tempValue);
                            if (height >= 150 && height <= 193)
                            {
                                PassportDictionary.Add(key, value);
                            }
                        }
                        else if (value.ToLower().EndsWith("in"))
                        {
                            var tempValue = value.Replace("in", "");
                            int height = Int16.Parse(tempValue);
                            if (height >= 59 && height <= 76)
                            {
                                PassportDictionary.Add(key, value);
                            }
                        }
                        break;

                    case "hcl":
                        if (value.StartsWith("#") && value.Length == 7)
                        {
                            var tempValue = value.Substring(1);
                            if (tempValue.All(c => "0123456789abcdef".Contains(c)))
                            {
                                PassportDictionary.Add(key, value);
                            }
                        }

                        break;

                    case "ecl":
                        if (ValidEyeColourList.Contains(value))
                        {
                            PassportDictionary.Add(key, value);
                        }

                        break;

                    case "pid":
                        if (value.Length == 9 && Int32.TryParse(value, out _))
                        {
                            PassportDictionary.Add(key, value);
                        }
                        break;
                }
            }
        }

        public bool IsValid()
        {
            if (PassportDictionary.Count == 7)
            {
                return true;
            }

            return false;
        }
    }
}
