namespace AdventOfCode2024.Day07.Task01;

using System.Linq;

public static class Calibrator
{
    public static long GetCalibrationResult(IEnumerable<(long Result, IEnumerable<int> Values)> equations)
    {
        IEnumerable<long> validEquationsResult = equations
            .Where(equation =>
            {
                int[] values = equation.Values.ToArray();
                int flags = 0;

                int? firstUnsetFlagPos;
                while (true)
                {
                    long currResult = values[0];
                    firstUnsetFlagPos = null;

                    for (int i = 0; i < values.Length - 1; i++)
                    {
                        if (((flags >> i) & 1) == 0)
                        {
                            if (firstUnsetFlagPos == null)
                            {
                                firstUnsetFlagPos = i;
                                flags += 1 << i;
                            }

                            currResult += values[i + 1];
                            continue;
                        }

                        currResult *= values[i + 1];
                    }

                    if (currResult == equation.Result)
                    {
                        return true;
                    }

                    if (firstUnsetFlagPos == null)
                    {
                        break;
                    }

                    for (int i = 0; i < firstUnsetFlagPos; i++)
                    {
                        flags -= 1 << i;
                    }
                }

                return false;
            })
            .Select(equation => equation.Result);

        return validEquationsResult.Any()
            ? validEquationsResult.Aggregate((curr, next) => curr + next)
            : 0;
    }
}
