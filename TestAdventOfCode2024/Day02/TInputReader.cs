namespace TestAdventOfCode2024.Day02;

using System.Linq;
using AdventOfCode2024.Day02.InputReader;

[TestFixture]
public sealed class TInputReader
{
    [TestCaseSource(typeof(TestCases), nameof(TestCases.InputCases))]
    public int[][] ReadInputString_ValidInputs_ShouldReturnCorrectInputRepresentation(string input)
    {
        // assert
        return InputReader.ReadInputString(input).Select(report => report.ToArray()).ToArray();
    }
}
