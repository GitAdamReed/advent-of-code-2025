using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2025.Classes
{
    public abstract class Day
    {
        private const string _inputPath = "C:\\Users\\adamr\\Documents\\GitHub\\Advent_Of_Code\\advent-of-code-2025\\AdventOfCode2025\\AdventOfCode2025\\Input";
        private const string _outputPath = "C:\\Users\\adamr\\Documents\\GitHub\\Advent_Of_Code\\advent-of-code-2025\\AdventOfCode2025\\AdventOfCode2025\\Output";
        
        protected string InputPath { get; } = _inputPath;
        protected string OutputPath { get; } = _outputPath;

        protected abstract void CreateOutput();
    }
}
