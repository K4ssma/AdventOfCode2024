namespace AdventOfCode2024.Day05.Task01;

using System;

public static class PrintValidator
{
    public static int GetValidMiddleSum(string input)
    {
        string[] inputLines = input.Split("\r\n");

        int? breakIndex = null;

        for (int i = 0; i < inputLines.Length; i++)
        {
            if (inputLines[i] != string.Empty)
            {
                continue;
            }

            breakIndex = i;
            break;
        }

        IEnumerable<string> orderRuleLines = inputLines.Take(breakIndex!.Value);
        IEnumerable<string> printQueueLines = inputLines.Skip(breakIndex!.Value + 1);

        Dictionary<int, int[]> ruleSet = orderRuleLines
            .Select(ruleLine =>
            {
                string[] numStrings = ruleLine.Split('|');

                return (int.Parse(numStrings[0]), int.Parse(numStrings[1]));
            })
            .GroupBy(rule => rule.Item1)
            .Select(ruleGroup =>
            {
                int[] followingNumbers = ruleGroup.Select(rule => rule.Item2).ToArray();

                return (ruleGroup.Key, followingNumbers);
            })
            .ToDictionary();

        IEnumerable<int> validMiddleValues = printQueueLines
            .Select(lineString =>
            {
                return lineString
                    .Split(',')
                    .Select(numString => int.Parse(numString))
                    .ToArray();
            })
            .Where(queueLine =>
            {
                for (int i = queueLine.Length - 1; i >= 0; i--)
                {
                    if (!ruleSet.ContainsKey(queueLine[i]))
                    {
                        continue;
                    }

                    for (int j = 0; j < i; j++)
                    {
                        if (ruleSet[queueLine[i]].Contains(queueLine[j]))
                        {
                            return false;
                        }
                    }
                }

                return true;
            })
            .Select(validLine => validLine[validLine.Length / 2]);

        return validMiddleValues.Any()
            ? validMiddleValues.Aggregate((curr, next) => curr + next)
            : 0;
    }
}
