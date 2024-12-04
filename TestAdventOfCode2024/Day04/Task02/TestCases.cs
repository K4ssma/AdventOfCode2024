namespace TestAdventOfCode2024.Day04.Task02;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class TestCases
{
    public static IEnumerable<TestCaseData> XmasCases
    {
        get
        {
            yield return new TestCaseData(
                "M.M\r\n" +
                ".A.\r\n" +
                "S.S").Returns(1).SetName("TestCase 01");

            yield return new TestCaseData(
                "M.S\r\n" +
                ".A.\r\n" +
                "M.S").Returns(1).SetName("TestCase 02");

            yield return new TestCaseData(
                "S.M\r\n" +
                ".A.\r\n" +
                "S.M").Returns(1).SetName("TestCase 03");

            yield return new TestCaseData(
                "S.S\r\n" +
                ".A.\r\n" +
                "M.M").Returns(1).SetName("TestCase 04");

            yield return new TestCaseData(
                ".M.S......\r\n" +
                "..A..MSMS.\r\n" +
                ".M.S.MAA..\r\n" +
                "..A.ASMSM.\r\n" +
                ".M.S.M....\r\n" +
                "..........\r\n" +
                "S.S.S.S.S.\r\n" +
                ".A.A.A.A..\r\n" +
                "M.M.M.M.M.\r\n" +
                "..........").Returns(9).SetName("Complex-Example");
        }
    }
}
