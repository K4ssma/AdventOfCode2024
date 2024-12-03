namespace TestAdventOfCode2024.Day01.Task02;

using AdventOfCode2024.Day01.Task02;

[TestFixture]
public sealed class TSimilarityCalculator
{
    [TestCaseSource(typeof(TestCases), nameof(TestCases.SimilarityCases))]
    public int CalculateSimilarityScore_ShouldReturnCorrectScore((int NumOne, int NumTwo)[] numbers)
    {
        // assert
        return SimilarityCalculator.CalculateSimilarityScore(numbers);
    }
}
