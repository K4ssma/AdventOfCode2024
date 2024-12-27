namespace AdventOfCode2024.Day08;

using System.Collections.Generic;
using AdventOfCode2024.HelperClasses;

public static class InputReader
{
    public static (Vector2Int Dimensions, Dictionary<char, List<Vector2Int>> AntennaSets) ReadInputString(
        string inputString)
    {
        string[] rowStrings = inputString.Split("\r\n");
        Dictionary<char, List<Vector2Int>> antennaSets = [];

        for (int y = 0; y < rowStrings.Length; y++)
        {
            if (rowStrings[y].Length != rowStrings[0].Length)
            {
                throw new FormatException("all mapstring rows need to have the same length");
            }

            for (int x = 0; x < rowStrings[y].Length; x++)
            {
                if (rowStrings[y][x] == '.')
                {
                    continue;
                }

                if (antennaSets.TryGetValue(rowStrings[y][x], out List<Vector2Int>? antennaSet))
                {
                    antennaSet.Add(new(x, y));
                    continue;
                }

                antennaSet = [];
                antennaSet.Add(new(x, y));
                antennaSets.Add(rowStrings[y][x], antennaSet);
            }
        }

        return (new(rowStrings[0].Length, rowStrings.Length), antennaSets);
    }
}
