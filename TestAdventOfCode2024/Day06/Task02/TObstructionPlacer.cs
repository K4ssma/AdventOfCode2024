namespace TestAdventOfCode2024.Day06.Task02;

using AdventOfCode2024.Day06.Task02;

[TestFixture]
public sealed class TObstructionPlacer
{
    [Test]
    public void GetPossibleObstructionCount_ShouldReturnCorrectObstructionAmount()
    {
        // arrange
        string mapString =
            "....#.....\r\n" +
            ".........#\r\n" +
            "..........\r\n" +
            "..#.......\r\n" +
            ".......#..\r\n" +
            "..........\r\n" +
            ".#..^.....\r\n" +
            "........#.\r\n" +
            "#.........\r\n" +
            "......#...";

        // act
        int possibleObstructionCount = ObstructionPlacer.GetPossibleObstructionCount(mapString);

        // assert
        Assert.That(possibleObstructionCount, Is.EqualTo(6));
    }
}
