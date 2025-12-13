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
            File.WriteAllText(GetTextFilePath("output"), $"Part 1: {CrackCodePart1()}\n");
            File.AppendAllText(GetTextFilePath("output"), $"Part 2: {CrackCodePart2()}");
        }

        private int CrackCodePart1()
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

        private int CrackCodePart2()
        {
            int currNum = 50;
            int clickCount = 0;
            string[] instructions = File.ReadAllLines(GetTextFilePath("input"));

            foreach (var i in instructions)
            {
                int delta = Int32.Parse(i[1..]);

                if (i[0] == 'L')
                {
                    for (int j = currNum; j > currNum - delta; j--)
                    {
                        if (j % 100 == 0) clickCount++;
                    }
                    currNum -= delta % 100;
                }
                else
                {
                    for (int j = currNum; j < currNum + delta; j++)
                    {
                        if (j % 100 == 0) clickCount++;
                    }
                    currNum += delta % 100;
                }

                if (currNum > 99) currNum -= 100;
                else if (currNum < 0) currNum += 100;
            }

            return clickCount;
        }
    }
}
