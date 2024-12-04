namespace TestAdventOfCode2024.Day03.Task01;

using AdventOfCode2024.Day03.Task01;

[TestFixture]
public sealed class TInstructionScanner
{
    [TestCaseSource(typeof(TestCases), nameof(TestCases.InstructionCases))]
    public int GetInstructionResult_ValidInstructions_ShouldReturnCorrectResult(string instruction)
    {
        // assert
        return InstructionScanner.GetInstructionResult(instruction);
    }
}
