namespace AdventOfCode2024.Day01;

using System;
using System.Collections.Generic;

public static class InputReader
{
    public static IEnumerable<(int NumOne, int NumTwo)> ReadInputString(string input)
    {
        string[] numStringPairs = input.Trim().Split("\r\n");

        return numStringPairs
            .Select(numStringPair =>
            {
                string[] numStrings = numStringPair.Trim().Split(' ');

                numStrings = numStrings
                    .Where(numString => numString != string.Empty)
                    .ToArray();

                if (numStrings.Length != 2)
                {
                    throw new ArgumentException($"input string has wrong format near {numStringPair}" +
                        $", numbers need to be grouped by two but was group of {numStrings.Length}");
                }

                return int.TryParse(numStrings[0], out int numOne)
                    && int.TryParse(numStrings[1], out int numTwo)
                    ? (numOne, numTwo)
                    : throw new ArgumentException($"input string has wrong format near {numStringPair}" +
                        ", numbers are not parseable to an integer");
            });
    }
}
