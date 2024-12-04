namespace TestAdventOfCode2024.Day03.Task01;

using System.Collections.Generic;

public static class TestCases
{
    public static IEnumerable<TestCaseData> InstructionCases
    {
        get
        {
            yield return new TestCaseData("mul(44,46)").Returns(44 * 46).SetName("Test 01");

            yield return new TestCaseData("mul(123,4)").Returns(123 * 4).SetName("Test 02");

            yield return new TestCaseData("mul(4*").Returns(0).SetName("Test 03");

            yield return new TestCaseData("mul(6,9!").Returns(0).SetName("Test 04");

            yield return new TestCaseData("?(12,34)").Returns(0).SetName("Test 05");

            yield return new TestCaseData("mul ( 2 , 4 )").Returns(0).SetName("Test 06");

            yield return new TestCaseData(
                "xmul(2,4)%&mul[3,7]!@^do_not_mul(5,5)+mul(32,64]then(mul(11,8)mul(8,5))")
                .Returns((2 * 4) + (5 * 5) + (11 * 8) + (8 * 5))
                .SetName("Complex Test");
        }
    }
}
