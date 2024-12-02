namespace TestAdventOfCode2024.Day01.Task01;

using System.Collections.Generic;

public static class TestCases
{
    public static IEnumerable<TestCaseData> ValidInputStrings
    {
        get
        {
            string testString =
                "3   4\r\n" +
                "4   3\r\n" +
                "2   5\r\n" +
                "1   3\r\n" +
                "3   9\r\n" +
                "3   3";

            yield return new TestCaseData(testString)
                .Returns(new (int NumOne, int NumTwo)[]
                {
                    new(3, 4),
                    new(4, 3),
                    new(2, 5),
                    new(1, 3),
                    new(3, 9),
                    new(3, 3),
                });

            testString =
                "1 9\r\n" +
                "2 8\r\n" +
                "3 7\r\n";

            yield return new TestCaseData(testString)
                .Returns(new (int NumOne, int NumTwo)[]
                {
                    new(1, 9),
                    new(2, 8),
                    new(3, 7),
                });
        }
    }

    public static IEnumerable<string> InvalidInputStrings
    {
        get
        {
            yield return "1 2 3";

            yield return "1 2\r\n3";
        }
    }

    public static IEnumerable<TestCaseData> DistanceCases
    {
        get
        {
            yield return new TestCaseData(new (int NumOne, int NumTwo)[]
            {
                new(1, 2),
            }).Returns(1);

            yield return new TestCaseData(new (int NumOne, int NumTwo)[]
            {
                new(1, 3),
                new(2, 1),
            }).Returns(1);

            yield return new TestCaseData(new (int NumOne, int NumTwo)[]
            {
                new(3, 1),
                new(1, 2),
            }).Returns(1);
        }
    }
}
