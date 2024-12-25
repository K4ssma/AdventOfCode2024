namespace AdventOfCode2024.Day07;

using System.Collections.Generic;
using System.Linq;

public static class InputReader
{
    public static IEnumerable<(long Result, IEnumerable<int> Values)> ReadInputString(string inputString)
    {
        string[] rowStrings = inputString.Split("\r\n");

        foreach (string rowString in rowStrings)
        {
            string[] equationStringParts = rowString.Split(": ");

            long result = long.Parse(equationStringParts[0]);
            IEnumerable<int> values = equationStringParts[1]
                .Split(' ')
                .Select(valueString => int.Parse(valueString));

            yield return (result, values);
        }
    }
}
