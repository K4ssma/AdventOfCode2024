namespace AdventOfCode2024.Day07.Task02;

using System;
using System.Collections.Generic;

public static class ImprovedCalibrator
{
    private static readonly Func<long, int, long>[] Operations = [Addition, Multiplication, Concatination];

    public static long GetCalibrationResult(IEnumerable<(long Result, IEnumerable<int> Values)> equations)
    {
        IEnumerable<long> validEquationResults = equations
            .Where(equation =>
            {
                int[] values = equation.Values.ToArray();
                byte[] flags = new byte[values.Length - 1];

                while (true)
                {
                    long currResult = values[0];
                    int? firstIterateableOperationFlagIndex = null;

                    for (int i = 0; i < values.Length - 1; i++)
                    {
                        currResult = Operations[flags[i]](currResult, values[i + 1]);

                        if (firstIterateableOperationFlagIndex == null
                            && flags[i] < Operations.Length - 1)
                        {
                            flags[i]++;
                            firstIterateableOperationFlagIndex = i;
                        }
                    }

                    if (currResult == equation.Result)
                    {
                        return true;
                    }

                    if (firstIterateableOperationFlagIndex == null)
                    {
                        return false;
                    }

                    for (int i = 0; i < firstIterateableOperationFlagIndex; i++)
                    {
                        flags[i] = 0;
                    }
                }
            })
            .Select(equation => equation.Result);

        return validEquationResults.Any()
            ? validEquationResults.Aggregate((curr, next) => curr + next)
            : 0;
    }

    private static long Addition(long numOne, int numTwo)
    {
        return numOne + numTwo;
    }

    private static long Multiplication(long numOne, int numTwo)
    {
        return numOne * numTwo;
    }

    private static long Concatination(long numOne, int numTwo)
    {
        int chars = 1;
        int tmp = numTwo;

        while (tmp / 10 > 0)
        {
            chars++;
            tmp /= 10;
        }

        return (long)((numOne * Math.Pow(10, chars)) + numTwo);
    }
}
