namespace TestAdventOfCode2024.Day05.Task01;

using AdventOfCode2024.Day05.Task01;

[TestFixture]
public sealed class TPrintValidator
{
    [TestCaseSource(typeof(TestCases), nameof(TestCases.PrintPageCases))]
    public int GetValidMiddleSum_ShouldReturnCorrectSum(string input)
    {
        // assert
        return PrintValidator.GetValidMiddleSum(input);
    }
}
