namespace TestAdventOfCode2024.Day04.Task01;

using System.Collections.Generic;

public static class TestCases
{
    public static IEnumerable<TestCaseData> WordFieldCases
    {
        get
        {
            yield return new TestCaseData(
                "....XMAS..").Returns(1).SetName("Case: horizontal");

            yield return new TestCaseData(
                "..SAMX....").Returns(1).SetName("Case: horizontal reversed");

            yield return new TestCaseData(
                "..SAMXMAS.").Returns(2).SetName("Case: horizontal overlap");

            yield return new TestCaseData(
                ".X..\r\n" +
                ".M..\r\n" +
                ".A..\r\n" +
                ".S..").Returns(1).SetName("Case: vertical");

            yield return new TestCaseData(
                "..S.\r\n" +
                "..A.\r\n" +
                "..M.\r\n" +
                "..X.").Returns(1).SetName("Case: vertical reversed");

            yield return new TestCaseData(
                "S...\r\n" +
                "A...\r\n" +
                "M...\r\n" +
                "X...\r\n" +
                "M...\r\n" +
                "A...\r\n" +
                "S...").Returns(2).SetName("Case: vertical overlap");

            yield return new TestCaseData(
                ".X...\r\n" +
                "..M..\r\n" +
                "...A.\r\n" +
                "....S").Returns(1).SetName("Case: diagonal left to right");

            yield return new TestCaseData(
                "S....\r\n" +
                ".A...\r\n" +
                "..M..\r\n" +
                "...X.").Returns(1).SetName("Case: diagonal reversed left to right");

            yield return new TestCaseData(
                ".....X.\r\n" +
                "....M..\r\n" +
                "...A...\r\n" +
                "..S....").Returns(1).SetName("Case: diagonal right to left");

            yield return new TestCaseData(
                "....S..\r\n" +
                "...A...\r\n" +
                "..M....\r\n" +
                ".X.....").Returns(1).SetName("Case: diagonal reversed right to left");

            yield return new TestCaseData(
                "....XXMAS.\r\n" +
                ".SAMXMS...\r\n" +
                "...S..A...\r\n" +
                "..A.A.MS.X\r\n" +
                "XMASAMX.MM\r\n" +
                "X.....XA.A\r\n" +
                "S.S.S.S.SS\r\n" +
                ".A.A.A.A.A\r\n" +
                "..M.M.M.MM\r\n" +
                ".X.X.XMASX").Returns(18).SetName("Complex Example");
        }
    }
}
