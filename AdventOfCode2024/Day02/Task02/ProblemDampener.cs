namespace AdventOfCode2024.Day02.Task02;

using System;

public static class ProblemDampener
{
    public static int GetNumOfSafeReports(int[][] reports)
    {
        return reports
            .Count(report =>
            {
                if (IsReportSafe(report))
                {
                    return true;
                }

                for (int i = 0; i < report.Length; i++)
                {
                    int[] modifiedReport = report
                        .Take(i)
                        .Concat(report.Skip(i + 1))
                        .ToArray();

                    if (IsReportSafe(modifiedReport))
                    {
                        return true;
                    }
                }

                return false;
            });
    }

    private static bool IsReportSafe(int[] report)
    {
        if (report.Length < 3)
        {
            return true;
        }

        bool shouldAscend = report[0] < report[1];

        for (int i = 0; i < report.Length - 1; i++)
        {
            int stepSize = Math.Abs(report[i] - report[i + 1]);

            if (stepSize < 1 || stepSize > 3)
            {
                return false;
            }

            bool isAscending = report[i] < report[i + 1];

            if ((isAscending && !shouldAscend) || (!isAscending && shouldAscend))
            {
                return false;
            }
        }

        return true;
    }
}
