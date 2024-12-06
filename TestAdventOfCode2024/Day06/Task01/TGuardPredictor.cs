namespace TestAdventOfCode2024.Day06.Task01;

using AdventOfCode2024.Day06.Task01;

[TestFixture]
public sealed class TGuardPredictor
{
    [TestCaseSource(typeof(TestCases), nameof(TestCases.MapCases))]
    public int PredictGuardLocations_ShouldReturnCorrectLocationCount(string map)
    {
        // assert
        return GuardPredictor.PredictGuardLocations(map);
    }
}
