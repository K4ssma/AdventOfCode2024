namespace TestAdventOfCode2024.Day04.Task01;

using AdventOfCode2024.Day04.Task01;

[TestFixture]
public sealed class TWordSearcher
{
    [TestCaseSource(typeof(TestCases), nameof(TestCases.WordFieldCases))]
    public int GetXmasCount_ShouldReturnCorrectCount(string searchField)
    {
        // assert
        return WordSearcher.GetXmasCount(searchField);
    }
}
