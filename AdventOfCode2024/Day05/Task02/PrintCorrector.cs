namespace AdventOfCode2024.Day05.Task02;

using System;

public static class PrintCorrector
{
    public static int GetCorrectedMiddleSum(string input)
    {
        string[] inputLines = input.Split("\r\n");

        int? breakIndex = null;

        for (int i = 0; i < inputLines.Length; i++)
        {
            if (inputLines[i] == string.Empty)
            {
                breakIndex = i;
                break;
            }
        }

        Dictionary<int, int[]> ruleSet = inputLines
            .Take(breakIndex!.Value)
            .Select(ruleString =>
            {
                int[] nums = ruleString
                    .Split('|')
                    .Select(numString => int.Parse(numString))
                    .ToArray();

                return (nums[0], nums[1]);
            })
            .GroupBy(rule => rule.Item1)
            .Select(ruleGroup =>
            {
                int[] followingNums = ruleGroup
                    .Select(rule => rule.Item2)
                    .ToArray();

                return (ruleGroup.Key, followingNums);
            })
            .ToDictionary();

        IEnumerable<int> middleValues = inputLines
            .Skip(breakIndex!.Value + 1)
            .Select(queueString =>
            {
                return queueString
                    .Split(',')
                    .Select(numString => int.Parse(numString))
                    .ToArray();
            })
            .Where(printQueue =>
            {
                for (int i = printQueue.Length - 1; i >= 0; i--)
                {
                    if (!ruleSet.ContainsKey(printQueue[i]))
                    {
                        continue;
                    }

                    for (int j = 0; j < i; j++)
                    {
                        if (ruleSet[printQueue[i]].Contains(printQueue[j]))
                        {
                            return true;
                        }
                    }
                }

                return false;
            })
            .Select(invalidPrintQueue =>
            {
                LinkedList<int> printQueue = new();

                printQueue.AddFirst(invalidPrintQueue[0]);

                for (int i = 1; i < invalidPrintQueue.Length; i++)
                {
                    bool gotInserted = false;

                    LinkedListNode<int> currNode = printQueue.Last!;

                    while (!gotInserted)
                    {
                        if (ruleSet.TryGetValue(currNode.Value, out int[]? value)
                            && value.Contains(invalidPrintQueue[i]))
                        {
                            printQueue.AddAfter(currNode, invalidPrintQueue[i]);
                            gotInserted = true;
                        }
                        else if (currNode.Previous == null)
                        {
                            printQueue.AddFirst(invalidPrintQueue[i]);
                            gotInserted = true;
                        }
                        else
                        {
                            currNode = currNode.Previous;
                        }
                    }
                }

                int[] validQueue = [.. printQueue];

                return validQueue[validQueue.Length / 2];
            });

        return middleValues.Any()
            ? middleValues.Aggregate((curr, next) => curr + next)
            : 0;
    }
}
