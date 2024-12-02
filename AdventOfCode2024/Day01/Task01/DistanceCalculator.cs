namespace AdventOfCode2024.Day01.Task01;

using System;

public static class DistanceCalculator
{
    public static int CalculateOverallDistance((int NumOne, int NumTwo)[] numPairs)
    {
        int[] firstNums = numPairs
            .Select(numPair => numPair.NumOne)
            .Order()
            .ToArray();

        int[] secondNums = numPairs
            .Select(numPair => numPair.NumTwo)
            .Order()
            .ToArray();

        int[] distances = new int[firstNums.Length];

        for (int i = 0; i < distances.Length; i++)
        {
            distances[i] = Math.Abs(firstNums[i] - secondNums[i]);
        }

        return distances.Aggregate((curr, next) => curr + next);
    }
}
