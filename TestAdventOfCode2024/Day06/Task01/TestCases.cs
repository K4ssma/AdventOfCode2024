namespace TestAdventOfCode2024.Day06.Task01;

using System.Collections.Generic;
using AdventOfCode2024.Day06.HelperClasses;

public static class TestCases
{
    public static IEnumerable<TestCaseData> MapCases
    {
        get
        {
            yield return new TestCaseData(
                new bool?[,]
                {
                    { false },
                    { false },
                    { false },
                    { false },
                    { false },
                    { null },
                    { false },
                    { false },
                },
                new GuardState()
                {
                    Pos = new() { X = 1, Y = 0 },
                    Direction = Direction.East,
                }).Returns(4).SetName("TestCase 01");

            yield return new TestCaseData(
                new bool?[,]
                {
                    { false },
                    { null },
                    { false },
                    { false },
                    { false },
                    { false },
                    { false },
                },
                new GuardState()
                {
                    Pos = new() { X = 5, Y = 0 },
                    Direction = Direction.West,
                }).Returns(4).SetName("TestCase 02");

            yield return new TestCaseData(
                new bool?[,]
                {
                    { false, false, false, false, false, false, false },
                    { false, null, false, false, false, false, false },
                },
                new GuardState()
                {
                    Pos = new() { X = 1, Y = 5 },
                    Direction = Direction.North,
                }).Returns(4).SetName("TestCase 03");

            yield return new TestCaseData(
                new bool?[,]
                {
                    { false, false, false, false, false, null, false },
                    { false, false, false, false, false, false, false },
                },
                new GuardState()
                {
                    Pos = new() { X = 0, Y = 1 },
                    Direction = Direction.South,
                }).Returns(4).SetName("TestCase 04");

            yield return new TestCaseData(
                new bool?[,]
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
                },
                new GuardState()
                {
                    Pos = new() { X = 4, Y = 6 },
                    Direction = Direction.North,
                }).Returns(41).SetName("Complex Example");
        }
    }
}
