namespace TestAdventOfCode2024.Day01.Task01;

using AdventOfCode2024.Day01.Task01;

[TestFixture]
public static class TDistanceCalculator
{
    [TestCaseSource(typeof(TestCases), nameof(TestCases.DistanceCases))]
    public static int CalculateOverallDistance_ShouldReturnCorrectDistance((int NumOne, int NumTwo)[] numbers)
    {
        // assert
        return DistanceCalculator.CalculateOverallDistance(numbers);
    }
}
