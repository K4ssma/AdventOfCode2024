namespace AdventOfCode2024.Day03.Task02;

using System.Text.RegularExpressions;

public static class ConditionalInstructionScanner
{
    public static int GetInstructionResult(string instruction)
    {
        MatchCollection validInstructions = Regex
            .Matches(instruction, @"(?<do>do\(\))|(?<dont>don't\(\))|mul\(\d{1,3},\d{1,3}\)");

        Regex compiledNumRegex = new(@"\d{1,3}", RegexOptions.Compiled);

        bool isActive = true;
        int result = 0;

        foreach (Match validInstruction in validInstructions)
        {
            if (validInstruction.Groups["do"].Success)
            {
                isActive = true;
                continue;
            }
            else if (validInstruction.Groups["dont"].Success)
            {
                isActive = false;
                continue;
            }

            if (!isActive)
            {
                continue;
            }

            result += compiledNumRegex
                    .Matches(validInstruction.Value)
                    .Select(numMatch => int.Parse(numMatch.Value))
                    .Aggregate((curr, next) => curr * next);
        }

        return result;
    }
}
