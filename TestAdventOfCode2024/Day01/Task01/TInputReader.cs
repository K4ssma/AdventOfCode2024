namespace TestAdventOfCode2024.Day01.Task01;

using System.Linq;
using AdventOfCode2024.Day01;

[TestFixture]
public class TInputReader
{
    [TestCaseSource(typeof(TestCases), nameof(TestCases.ValidInputStrings))]
    public (int NumOne, int NumTwo)[]
        ReadInputString_ValidInputString_ShouldReturnNumPairs(string inputString)
    {
        // assert
        return InputReader.ReadInputString(inputString).ToArray();
    }

    [TestCaseSource(typeof(TestCases), nameof(TestCases.InvalidInputStrings))]
    public void ReadInputString_InvalidInputStrings_ShouldThrowArgumentexception(string inputString)
    {
        // assert
        Assert.Throws<ArgumentException>(() => InputReader.ReadInputString(inputString).ToArray());
    }
}
