namespace TestAdventOfCode2024.Day03.Task02;

using AdventOfCode2024.Day03.Task02;

[TestFixture]
public sealed class TConditionalInstructionScanner
{
    [TestCaseSource(typeof(TestCases), nameof(TestCases.InstructionCases))]
    public int GetInstructionResult_ShouldReturnCorrectResult(string instruction)
    {
        // assert
        return ConditionalInstructionScanner.GetInstructionResult(instruction);
    }
}
