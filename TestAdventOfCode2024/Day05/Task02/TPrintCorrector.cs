namespace TestAdventOfCode2024.Day05.Task02;

using AdventOfCode2024.Day05.Task02;

[TestFixture]
public sealed class TPrintCorrector
{
    [TestCaseSource(typeof(TestCases), nameof(TestCases.PrintPageCases))]
    public int GetCorrectedMiddleSum_ShouldReturnCorrectSum(string input)
    {
        // assert
        return PrintCorrector.GetCorrectedMiddleSum(input);
    }
}
