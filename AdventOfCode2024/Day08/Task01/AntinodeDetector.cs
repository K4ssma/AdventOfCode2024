﻿namespace AdventOfCode2024.Day08.Task01;

using System.Collections.Generic;
using AdventOfCode2024.HelperClasses;

public static class AntinodeDetector
{
    public static int CountUniqueAntinodeSpots(
        Vector2Int dimensions, Dictionary<char, List<Vector2Int>> antennaSets)
    {
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
                        || nodePos.X >= dimensions.X
                        || nodePos.Y < 0
                        || nodePos.Y >= dimensions.Y)
                    {
                        continue;
                    }

                    antinodes.Add(nodePos);
                }
            }
        }

        return antinodes.Count;
    }
}
