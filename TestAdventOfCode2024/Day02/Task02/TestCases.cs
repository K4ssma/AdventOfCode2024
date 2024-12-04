namespace TestAdventOfCode2024.Day02.Task02;

using System.Collections.Generic;

public static class TestCases
{
    public static IEnumerable<TestCaseData> ReportCases
    {
        get
        {
            // second parameter only exists, so that the array doesn't get unwraped
            yield return new TestCaseData(
                new int[][]
                {
                    [7, 6, 4, 2, 1],
                },
                null).Returns(1).SetName("AdventOfCode Example 01");

            yield return new TestCaseData(
                new int[][]
                {
                    [1, 2, 7, 8, 9],
                },
                null).Returns(0).SetName("AdventOfCode Example 02");

            yield return new TestCaseData(
                new int[][]
                {
                    [9, 7, 6, 2, 1],
                },
                null).Returns(0).SetName("AdventOfCode Example 03");

            yield return new TestCaseData(
                new int[][]
                {
                    [1, 3, 2, 4, 5],
                },
                null).Returns(1).SetName("AdventOfCode Example 04");

            yield return new TestCaseData(
                new int[][]
                {
                    [8, 6, 4, 4, 1],
                },
                null).Returns(1).SetName("AdventOfCode Example 05");

            yield return new TestCaseData(
                new int[][]
                {
                    [1, 3, 6, 7, 9],
                },
                null).Returns(1).SetName("AdventOfCode Example 06");
        }
    }
}
