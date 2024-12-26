namespace AdventOfCode2024.Day08.Task01;

using System.Collections.Generic;

public static class AntinodeDetector
{
    public static int CountUniqueAntinodeSpots(string inputString)
    {
        Dictionary<char, List<Vector2Int>> antennaSets = [];
        string[] rowStrings = inputString.Split("\r\n");

        for (int y = 0; y < rowStrings.Length; y++)
        {
            for (int x = 0; x < rowStrings[y].Length; x++)
            {
                if (rowStrings[y][x] == '.')
                {
                    continue;
                }

                if (!antennaSets.ContainsKey(rowStrings[y][x]))
                {
                    antennaSets.Add(rowStrings[y][x], []);
                }

                antennaSets[rowStrings[y][x]].Add(new(x, y));
            }
        }

        HashSet<Vector2Int> antinodes = [];

        foreach (List<Vector2Int> antennas in antennaSets.Values)
        {
            for (int i = 0; i < antennas.Count; i++)
            {
                for (int j = 0; j < antennas.Count; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }

                    Vector2Int nodePos = new()
                    {
                        X = antennas[i].X + (antennas[i].X - antennas[j].X),
                        Y = antennas[i].Y + (antennas[i].Y - antennas[j].Y),
                    };

                    if (nodePos.X < 0
                        || nodePos.X >= rowStrings[0].Length
                        || nodePos.Y < 0
                        || nodePos.Y >= rowStrings.Length)
                    {
                        continue;
                    }

                    antinodes.Add(nodePos);
                }
            }
        }

        return antinodes.Count;
    }

    private struct Vector2Int(int x, int y)
    {
        public int X = x;
        public int Y = y;
    }
}
