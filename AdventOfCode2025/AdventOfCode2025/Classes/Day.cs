using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2025.Classes
{
    public abstract class Day
    {
        protected static string GetInputPath(string textfile)
        {
            return "C:\\Users\\adamr\\Documents\\GitHub\\Advent_Of_Code\\advent-of-code-2025\\AdventOfCode2025\\AdventOfCode2025\\Input\\" + textfile;
        }
        protected static string GetOutputPath(string textfile)
        {
            return "C:\\Users\\adamr\\Documents\\GitHub\\Advent_Of_Code\\advent-of-code-2025\\AdventOfCode2025\\AdventOfCode2025\\Output\\" + textfile;
        }
        protected abstract void CreateOutput();
    }
}
