namespace TestAdventOfCode2024.Day02;

using System.Collections.Generic;

public static class TestCases
{
    public static IEnumerable<TestCaseData> InputCases
    {
        get
        {
            string testString =
                "1 2 3\r\n" +
                "4 5 6 7\r\n" +
                "0";

            yield return new TestCaseData(testString).Returns(new int[][]
            {
                [1, 2, 3],
                [4, 5, 6, 7],
                [0],
            });

            testString =
                "7 6 4 2 1\r\n" +
                "1 2 7 8 9\r\n" +
                "9 7 6 2 1\r\n" +
                "1 3 2 4 5\r\n" +
                "8 6 4 4 1\r\n" +
                "1 3 6 7 9";

            yield return new TestCaseData(testString).Returns(new int[][]
            {
                [7, 6, 4, 2, 1],
                [1, 2, 7, 8, 9],
                [9, 7, 6, 2, 1],
                [1, 3, 2, 4, 5],
                [8, 6, 4, 4, 1],
                [1, 3, 6, 7, 9],
            });
        }
    }
}
