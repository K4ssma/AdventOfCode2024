namespace AdventOfCode2024.Day07.Task01;

using System.Linq;

public static class Calibrator
{
    public static long GetCalibrationResult(string inputString)
    {
        (long Result, int[] Values)[] equations = inputString
            .Split("\r\n")
            .Select(equationString =>
            {
                string[] splitEquationString = equationString.Split(": ");

                long result = long.Parse(splitEquationString[0]);
                int[] values = splitEquationString[1]
                    .Split(' ')
                    .Select(valueString => int.Parse(valueString))
                    .ToArray();

                return (result, values);
            })
            .ToArray();

        IEnumerable<long> validEquationsResult = equations
            .Where(equation =>
            {
                int flags = 0;

                int? firstUnsetFlagPos;
                while (true)
                {
                    long currResult = equation.Values[0];
                    firstUnsetFlagPos = null;

                    for (int i = 0; i < equation.Values.Length - 1; i++)
                    {
                        if (((flags >> i) & 1) == 0)
                        {
                            if (firstUnsetFlagPos == null)
                            {
                                firstUnsetFlagPos = i;
                                flags += 1 << i;
                            }

                            currResult += equation.Values[i + 1];
                            continue;
                        }

                        currResult *= equation.Values[i + 1];
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
