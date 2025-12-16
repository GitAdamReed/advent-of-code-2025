using AdventOfCode2025.Classes;

namespace Tests
{
    public class Day3Tests
    {
        [TestCase("987654321111111", 98)]
        [TestCase("811111111111119", 89)]
        [TestCase("234234234234278", 78)]
        [TestCase("818181911112111", 92)]
        public void FindJoltagePassesExamples(string example, int expectedResult)
        {
            Assert.That(Day3.FindJoltage(example), Is.EqualTo(expectedResult));
        }
    }
}
