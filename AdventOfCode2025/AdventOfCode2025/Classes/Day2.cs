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
            File.WriteAllText(GetTextFilePath("output"), $"Part 1: {SumInvalidIdsPart1()}\n");
            File.AppendAllText(GetTextFilePath("output"), $"Part 2: {SumInvalidIdsPart2()}");
        }

        private long SumInvalidIdsPart1()
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

        private long SumInvalidIdsPart2()
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
                    for (int j = currentId.Length / 2; j > 0; j--)
                    {
                        // Split the current ID into chunks
                        List<string> chunkList = [];
                        var chunks = currentId.Chunk(j);
                        foreach (var chunk in chunks)
                        {
                            StringBuilder sb = new();
                            foreach (char c in chunk) sb.Append(c);
                            chunkList.Add(sb.ToString());
                        }
                        
                        // Check if all chunks are equal
                        if (chunkList.All(x => x == chunkList[0]))
                        {
                            invalidIdSum += Int64.Parse(currentId);
                            break;
                        }
                    }
                }
            }

            return invalidIdSum;
        }
    }
}
