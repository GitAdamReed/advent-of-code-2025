using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2025.Classes
{
    public class Day1 : Day
    {
        protected override void CreateOutput()
        {
            File.WriteAllText(GetTextFilePath("output"), $"Part 1: {CrackCode()}");
        }

        private int CrackCode()
        {
            int currNum = 50;
            int zeroCount = 0;
            string[] instructions = File.ReadAllLines(GetTextFilePath("input"));

            foreach (var i in instructions)
            {
                int delta = Int32.Parse(i[1..]) % 100; // Same as Int32.Parse(i.Substring(1) % 100)
                if (i[0] == 'L') currNum -= delta;
                else currNum += delta;

                if (currNum > 99) currNum -= 100;
                else if (currNum < 0) currNum += 100;

                if (currNum == 0) zeroCount++;
            }

            return zeroCount;
        }
    }
}
