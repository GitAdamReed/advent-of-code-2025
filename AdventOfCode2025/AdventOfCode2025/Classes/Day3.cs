using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2025.Classes
{
    public class Day3 : Day
    {
        public static int FindJoltage(string batteryBank)
        {
            StringBuilder sb = new();
            List<int> batteries = batteryBank.ToList().ConvertAll(x => Int32.Parse(x.ToString()));

            int firstMax = 0;
            int secondMax = 0;
            for (int i = 0; i < batteries.Count - 1; i++)
            {
                if (batteries[i] > firstMax)
                {
                    firstMax = batteries[i];
                    secondMax = batteries[i + 1];
                }
                if (batteries[i + 1] > secondMax)
                {
                    secondMax = batteries[i + 1];
                }
            }

            return Int32.Parse($"{firstMax}{secondMax}");
        }

        protected override void CreateOutput()
        {
            File.WriteAllText(GetTextFilePath("output"), $"Part 1: {SumJoltage()}\n");
        }

        private int SumJoltage()
        {
            int totalJoltage = 0;
            string[] batBanks = File.ReadAllLines(GetTextFilePath("input"));
            
            foreach (var batBank in batBanks)
            {
                totalJoltage += FindJoltage(batBank);
            }

            return totalJoltage;
        }
    }
}
