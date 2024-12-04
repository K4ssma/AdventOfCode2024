namespace AdventOfCode2024.Day03.Task01;

using System.Text.RegularExpressions;

public static class InstructionScanner
{
    public static int GetInstructionResult(string instructionString)
    {
        Regex compiledRegex = new(@"\d{1,3}", RegexOptions.Compiled);

        MatchCollection matches = Regex.Matches(instructionString, @"mul\(\d{1,3},\d{1,3}\)");

        if (matches.Count == 0)
        {
            return 0;
        }

        return matches
            .Select(instruction =>
            {
                int[] numbers = compiledRegex
                    .Matches(instruction.Value)
                    .Select(numMatch => int.Parse(numMatch.Value))
                    .ToArray();

                return numbers[0] * numbers[1];
            })
            .Aggregate((curr, next) => curr + next);
    }
}
