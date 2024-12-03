namespace TestAdventOfCode2024.Day02.Task02;

using AdventOfCode2024.Day02.Task02;

[TestFixture]
public sealed class TProblemDampener
{
    [TestCaseSource(typeof(TestCases), nameof(TestCases.ReportCases))]
    public int GetNumOfSafeReports_ShouldReturnCorrectReportCount(int[][] reports, object? _)
    {
        // assert
        return ProblemDampener.GetNumOfSafeReports(reports);
    }
}
