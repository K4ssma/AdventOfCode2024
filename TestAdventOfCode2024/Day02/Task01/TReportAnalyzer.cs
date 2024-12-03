namespace TestAdventOfCode2024.Day02.Task01;

using AdventOfCode2024.Day02.Task01;

[TestFixture]
public sealed class TReportAnalyzer
{
    [TestCaseSource(typeof(TestCases), nameof(TestCases.ReportCases))]
    public int GetNumOfSafereports_ShouldReturnCorrectNum(int[][] reports)
    {
        // assert
        return ReportAnalyzer.GetNumOfSafeReports(reports);
    }
}
