namespace AdventOfCode2024.Day06.Task01;

using AdventOfCode2024.Day06.HelperClasses;

public static class GuardPredictor
{
    public static int PredictGuardPositions(string mapString)
    {
        FlagableMap map = new(mapString);

        int distinctPosCount = 0;

        do
        {
            if (map.MarkCurrPosIfEmpty())
            {
                distinctPosCount++;
            }
        }
        while (map.MoveNext());

        return distinctPosCount;
    }
}
