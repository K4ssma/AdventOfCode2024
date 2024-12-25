namespace TestAdventOfCode2024.Day07.Taske02;

using AdventOfCode2024.Day07;
using AdventOfCode2024.Day07.Task02;

[TestFixture]
public sealed class TImprovedCalibrator
{
    [TestCase("190: 10 19")]
    [TestCase("3267: 81 40 27")]
    [TestCase("292: 11 6 16 20")]
    [TestCase("156: 15 6")]
    [TestCase("7290: 6 8 6 15")]
    [TestCase("192: 17 8 14")]
    public void GetCalibrationResult_SolveableEquations_ShouldReturnResultPart(string inputString)
    {
        // arrange
        long expectedResult = long.Parse(inputString.Split(": ")[0]);

        // act
        long result = ImprovedCalibrator.GetCalibrationResult(InputReader.ReadInputString(inputString));

        // assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [TestCase("83: 17 5")]
    [TestCase("161011: 16 10 13")]
    [TestCase("21037: 9 7 18 13")]
    public void GetCalibrationResult_UnsolvableEquations_ShouldReturnZero(string inputString)
    {
        // act
        long result = ImprovedCalibrator.GetCalibrationResult(InputReader.ReadInputString(inputString));

        // assert
        Assert.That(result, Is.EqualTo(0));
    }
}
