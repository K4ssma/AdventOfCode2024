namespace TestAdventOfCode2024.Day08.Task01;

using AdventOfCode2024.Day08.Task01;

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
        int antinodeCount = AntinodeDetector.CountUniqueAntinodeSpots(inputString);

        // assert
        Assert.That(antinodeCount, Is.EqualTo(14));
    }
}
