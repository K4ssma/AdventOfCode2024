namespace TestAdventOfCode2024.Day07.Task01;

using AdventOfCode2024.Day07;
using AdventOfCode2024.Day07.Task01;

[TestFixture]
public sealed class TCalibrator
{
    [TestCase("190: 10 19")]
    [TestCase("3267: 81 40 27")]
    [TestCase("292: 11 6 16 20")]
    public void GetCalibrationResult_ValidEquations_ShouldReturnEquationResult(string equationString)
    {
        // arrange
        long expectedResult = long.Parse(equationString.Split(": ")[0]);

        // act
        long result = Calibrator.GetCalibrationResult(InputReader.ReadInputString(equationString));

        // assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [TestCase("83: 17 5")]
    [TestCase("156: 15 6")]
    [TestCase("7290: 6 8 6 15")]
    [TestCase("161011: 16 10 13")]
    [TestCase("192: 17 8 14")]
    [TestCase("21037: 9 7 18 13")]
    public void GetCalibrationResult_InvalidEquations_ShouldReturnZero(string equationString)
    {
        // act
        long result = Calibrator.GetCalibrationResult(InputReader.ReadInputString(equationString));

        // assert
        Assert.That(result, Is.EqualTo(0));
    }
}
