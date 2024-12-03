namespace AdventOfCode2024.Day02.Task01;

using System;
using System.Linq;

public static class ReportAnalyzer
{
    public static int GetNumOfSafeReports(int[][] reports)
    {
        return reports
            .Count(report =>
            {
                if (report.Length < 2)
                {
                    return true;
                }

                if (report[0] - report[1] == 0)
                {
                    return false;
                }

                bool isIncreasing = report[0] - report[1] < 0;

                int lastLvl = report[0];

                for (int i = 1; i < report.Length; i++)
                {
                    if ((report[i] - lastLvl <= 0 && isIncreasing)
                        || (report[i] - lastLvl >= 0 && !isIncreasing)
                        || Math.Abs(report[i] - lastLvl) > 3)
                    {
                        return false;
                    }

                    lastLvl = report[i];
                }

                return true;
            });
    }
}
