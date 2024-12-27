namespace TestAdventOfCode2024.Day08.Task01;

using AdventOfCode2024.Day08;
using AdventOfCode2024.Day08.Task01;
using AdventOfCode2024.HelperClasses;

[TestFixture]
public sealed class TAntinodeDetector
{
    [Test]
    public void CountUniqueAntinodeSpots_ShouldReturnCorrectAntinodeCount()
    {
        // arrange
        string inputString =
            "............\r\n" +
            "........0...\r\n" +
            ".....0......\r\n" +
            ".......0....\r\n" +
            "....0.......\r\n" +
            "......A.....\r\n" +
            "............\r\n" +
            "............\r\n" +
            "........A...\r\n" +
            ".........A..\r\n" +
            "............\r\n" +
            "............";

        // act
        (Vector2Int, Dictionary<char, List<Vector2Int>>) readInput = InputReader.ReadInputString(inputString);
        int antinodeCount = AntinodeDetector.CountUniqueAntinodeSpots(
            readInput.Item1, readInput.Item2);

        // assert
        Assert.That(antinodeCount, Is.EqualTo(14));
    }
}
