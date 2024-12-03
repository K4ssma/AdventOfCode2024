namespace AdventOfCode2024.Day02.InputReader;

using System;
using System.Collections.Generic;

public class InputReader : IInputReader
{
    public static IEnumerable<IEnumerable<int>> ReadInputString(string input)
    {
        return input
            .Trim()
            .Split("\r\n")
            .Select(levelString =>
            {
                string[] numStrings = levelString.Trim().Split(' ');

                return numStrings.Select(numString =>
                    {
                        return int.TryParse(numString, out int num)
                            ? num
                            : throw new FormatException($"unable to parse {numString} near {levelString}");
                    });
            });
    }
}
