using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2025.Classes
{
    public class Day2 : Day
    {
        protected override void CreateOutput()
        {
            File.WriteAllText(GetTextFilePath("output"), $"Part 1: {SumInvalidIds()}");
        }

        private long SumInvalidIds()
        {
            // Parse input
            string[] ids = File.ReadAllText(GetTextFilePath("input")).Split(",");
            List<string[]> idRanges = [];
            foreach (string id in ids) idRanges.Add(id.Split("-"));

            long invalidIdSum = 0;
            foreach (string[] range in idRanges)
            {
                long lower = Int64.Parse(range[0]);
                long higher = Int64.Parse(range[1]);
                for (long i = lower; i <= higher; i++)
                {
                    string currentId = i.ToString();
                    // Check if both halves of the string are equal
                    if (currentId[..(currentId.Length / 2)] == currentId[(currentId.Length / 2)..])
                    {
                        invalidIdSum += i;
                    }
                }
            }

            return invalidIdSum;
        }
    }
}
