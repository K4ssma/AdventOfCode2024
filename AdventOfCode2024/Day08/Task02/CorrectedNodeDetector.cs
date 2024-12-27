namespace AdventOfCode2024.Day08.Task02;

using System.Collections.Generic;
using AdventOfCode2024.HelperClasses;

public static class CorrectedNodeDetector
{
    public static int GetNodeCount(Vector2Int dimensions, Dictionary<char, List<Vector2Int>> antennaSets)
    {
        HashSet<Vector2Int> uniqueNodePositions = [];

        foreach (List<Vector2Int> antennaSet in antennaSets.Values)
        {
            for (int i = 0; i < antennaSet.Count; i++)
            {
                for (int j = 0; j < antennaSet.Count; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }

                    Vector2Int distance = new()
                    {
                        X = antennaSet[i].X - antennaSet[j].X,
                        Y = antennaSet[i].Y - antennaSet[j].Y,
                    };

                    Vector2Int newPos = antennaSet[j];

                    while (newPos.X >= 0
                        && newPos.X < dimensions.X
                        && newPos.Y >= 0
                        && newPos.Y < dimensions.Y)
                    {
                        uniqueNodePositions.Add(newPos);

                        newPos.X += distance.X;
                        newPos.Y += distance.Y;
                    }
                }
            }
        }

        return uniqueNodePositions.Count;
    }
}
