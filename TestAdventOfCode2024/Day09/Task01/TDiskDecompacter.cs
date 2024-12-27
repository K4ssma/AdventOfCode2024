namespace TestAdventOfCode2024.Day09.Task01;

using AdventOfCode2024.Day09.Task01;

[TestFixture]
public sealed class TDiskDecompacter
{
    [Test]
    public void GetChecksum()
    {
        // arrange
        string inputString = "2333133121414131402";

        // act
        int checkSum = DiskDecompacter.GetChecksum(inputString);

        // assert
        Assert.That(checkSum, Is.EqualTo(1928));
    }
}
