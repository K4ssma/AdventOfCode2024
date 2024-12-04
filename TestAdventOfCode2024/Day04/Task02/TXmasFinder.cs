namespace TestAdventOfCode2024.Day04.Task02;

using AdventOfCode2024.Day04.Task02;

[TestFixture]
public sealed class TXmasFinder
{
    [TestCaseSource(typeof(TestCases), nameof(TestCases.XmasCases))]
    public int GetXmasCount_ShouldReturnCorrectCount(string searchField)
    {
        // assert
        return XmasFinder.GetXMasCount(searchField);
    }
}
