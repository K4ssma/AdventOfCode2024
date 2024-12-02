namespace AdventOfCode2024.Day01.Task01.InputReader;

using System.Collections.Generic;

public interface IInputReader
{
    public static abstract IEnumerable<(int NumOne, int NumTwo)> ReadInputString(string input);
}
