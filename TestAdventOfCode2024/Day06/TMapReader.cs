namespace TestAdventOfCode2024.Day06;

using AdventOfCode2024.Day06.HelperClasses;

[TestFixture]
public sealed class TMapReader
{
    [TestCaseSource(typeof(TestCases), nameof(TestCases.MapStringCases))]
    public (bool?[,] Map, GuardState GuardState) ReadMapString(string mapString)
    {
        // assert
        return MapReader.ReadMapString(mapString);
    }
}
