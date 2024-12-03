namespace TestAdventOfCode2024.Day01.Task02;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class TestCases
{
    public static IEnumerable<TestCaseData> SimilarityCases
    {
        get
        {
            yield return new TestCaseData(new (int NumOne, int NumTwo)[]
            {
                new(1, 2),
                new(2, 1),
            }).Returns(3);

            yield return new TestCaseData(new (int NumOne, int NumTwo)[]
            {
                new(1, 1),
                new(2, 1),
            }).Returns(2);

            yield return new TestCaseData(new (int NumOne, int NumTwo)[]
            {
                new(1, 3),
                new(2, 3),
            }).Returns(0);
        }
    }
}
