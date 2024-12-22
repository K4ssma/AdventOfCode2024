namespace TestAdventOfCode2024.Day06.Task01;

using AdventOfCode2024.Day06.Task01;

[TestFixture]
public sealed class TGuardPredictor
{
    [Test]
    public void PredictGuardPositions_ShouldReturnCorrectDistinctGuardPositions()
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
        int posCount = GuardPredictor.PredictGuardPositions(mapString);

        // assert
        Assert.That(posCount, Is.EqualTo(41));
    }
}
