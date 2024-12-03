namespace TestAdventOfCode2024.Day02.Task01;

using System.Collections.Generic;

public static class TestCases
{
    public static IEnumerable<TestCaseData> ReportCases
    {
        get
        {
            // the secondParameter is needed in order to not unwrap the Array
            yield return new TestCaseData(
                new int[][]
                {
                    [1],
                },
                string.Empty).Returns(1);

            yield return new TestCaseData(
                new int[][]
                {
                    [1, 2, 3],
                },
                string.Empty).Returns(1);

            yield return new TestCaseData(
                new int[][]
                {
                    [3, 2, 1],
                },
                string.Empty).Returns(1);

            yield return new TestCaseData(
                new int[][]
                {
                    [1, 2, 1],
                },
                string.Empty).Returns(0);

            yield return new TestCaseData(
                new int[][]
                {
                    [1, 4],
                },
                string.Empty).Returns(1);

            yield return new TestCaseData(
                new int[][]
                {
                    [1, 5],
                },
                string.Empty).Returns(0);

            yield return new TestCaseData(
                new int[][]
                {
                    [4, 1],
                },
                string.Empty).Returns(1);

            yield return new TestCaseData(
                new int[][]
                {
                    [5, 0],
                },
                string.Empty).Returns(0);

            yield return new TestCaseData(
                new int[][]
                {
                    [7, 6, 4, 2, 1],
                    [1, 2, 7, 8, 9],
                    [9, 7, 6, 2, 1],
                    [1, 3, 2, 4, 5],
                    [8, 6, 4, 4, 1],
                    [1, 3, 6, 7, 9],
                },
                string.Empty).Returns(2);
        }
    }
}
