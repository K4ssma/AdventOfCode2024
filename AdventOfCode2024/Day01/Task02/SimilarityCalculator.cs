namespace AdventOfCode2024.Day01.Task02;

using System;

public static class SimilarityCalculator
{
    public static int CalculateSimilarityScore((int NumOne, int NumTwo)[] numbers)
    {
        return numbers
            .Select(numPair =>
            {
                int count = numbers.Count(pair => pair.NumTwo == numPair.NumOne);

                return numPair.NumOne * count;
            })
            .Aggregate((curr, next) => curr + next);
    }
}
