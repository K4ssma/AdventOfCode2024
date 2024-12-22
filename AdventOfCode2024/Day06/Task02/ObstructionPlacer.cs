namespace AdventOfCode2024.Day06.Task02;

using AdventOfCode2024.Day06.HelperClasses;

public static class ObstructionPlacer
{
    public static int GetPossibleObstructionCount(string mapString)
    {
        FlagableMap map = new(mapString);

        int possibleObstructionCount = 0;

        do
        {
            map.MarkCurrPosIfEmpty();

            map.SaveState();

            if (!map.PlaceObstruction())
            {
                break;
            }

            while (map.MoveNext())
            {
                if (map.IsOnLoop())
                {
                    possibleObstructionCount++;
                    break;
                }

                map.MarkCurrPosIfEmpty();
            }

            map.LoadSavedState();
        }
        while (map.MoveNext());

        return possibleObstructionCount;
    }
}
