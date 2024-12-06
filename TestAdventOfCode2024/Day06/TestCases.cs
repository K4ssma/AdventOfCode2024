namespace TestAdventOfCode2024.Day06;

using System.Collections.Generic;
using AdventOfCode2024.Day06.HelperClasses;

public static class TestCases
{
    public static IEnumerable<TestCaseData> MapStringCases
    {
        get
        {
            yield return new TestCaseData(
                ".>...#..")
                .Returns((new bool?[,]
                {
                    { false },
                    { false },
                    { false },
                    { false },
                    { false },
                    { null },
                    { false },
                    { false },
                }, new GuardState
                {
                    Pos = new() { X = 1, Y = 0 },
                    Direction = Direction.East,
                }))
                .SetName("TestCase 01");

            yield return new TestCaseData(
                ".#...<.")
                .Returns((new bool?[,]
                {
                    { false },
                    { null },
                    { false },
                    { false },
                    { false },
                    { false },
                    { false },
                }, new GuardState
                {
                    Pos = new() { X = 5, Y = 0 },
                    Direction = Direction.West,
                }))
                .SetName("TestCase 02");

            yield return new TestCaseData(
                "..\r\n" +
                ".#\r\n" +
                "..\r\n" +
                "..\r\n" +
                "..\r\n" +
                ".^\r\n" +
                "..")
                .Returns((new bool?[,]
                {
                    { false, false, false, false, false, false, false },
                    { false, null, false, false, false, false, false },
                }, new GuardState()
                {
                    Pos = new() { X = 1, Y = 5 },
                    Direction = Direction.North,
                }))
                .SetName("TestCase 03");

            yield return new TestCaseData(
                "..\r\n" +
                "v.\r\n" +
                "..\r\n" +
                "..\r\n" +
                "..\r\n" +
                "#.\r\n" +
                "..")
                .Returns((new bool?[,]
                {
                    { false, false, false, false, false, null, false },
                    { false, false, false, false, false, false, false },
                }, new GuardState()
                {
                    Pos = new() { X = 0, Y = 1 },
                    Direction = Direction.South,
                }))
                .SetName("TestCase 04");

            yield return new TestCaseData(
                "....#.....\r\n" +
                ".........#\r\n" +
                "..........\r\n" +
                "..#.......\r\n" +
                ".......#..\r\n" +
                "..........\r\n" +
                ".#..^.....\r\n" +
                "........#.\r\n" +
                "#.........\r\n" +
                "......#...")
                .Returns((new bool?[,]
                {
                    { false, false, false, false, false, false, false, false, null, false },
                    { false, false, false, false, false, false, null, false, false, false },
                    { false, false, false, null, false, false, false, false, false, false },
                    { false, false, false, false, false, false, false, false, false, false },
                    { null, false, false, false, false, false, false, false, false, false },
                    { false, false, false, false, false, false, false, false, false, false },
                    { false, false, false, false, false, false, false, false, false, null },
                    { false, false, false, false, null, false, false, false, false, false },
                    { false, false, false, false, false, false, false, null, false, false },
                    { false, null, false, false, false, false, false, false, false, false },
                }, new GuardState()
                {
                    Pos = new() { X = 4, Y = 6 },
                    Direction = Direction.North,
                }))
                .SetName("Complex Example");
        }
    }
}
