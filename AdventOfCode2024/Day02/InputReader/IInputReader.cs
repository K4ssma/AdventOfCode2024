namespace AdventOfCode2024.Day02.InputReader;

using System.Collections.Generic;

public interface IInputReader
{
    public static abstract IEnumerable<IEnumerable<int>> ReadInputString(string input);
}
