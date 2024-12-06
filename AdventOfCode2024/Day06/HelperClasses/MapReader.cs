namespace AdventOfCode2024.Day06.HelperClasses;

using System;

public static class MapReader
{
    public static (bool?[,] Map, GuardState Guard) ReadMapString(string mapString)
    {
        string[] mapStringRows = mapString.Split("\r\n");

        // null = obstacle, false = empty-field, true = visited-field
        bool?[,] map = new bool?[mapStringRows[0].Length, mapStringRows.Length];
        GuardState? guardState = null;

        for (int y = 0; y < mapStringRows.Length; y++)
        {
            if (mapStringRows[y].Length != map.GetLength(0))
            {
                throw new FormatException("it's prohibited for the map to have inconsistent column lengths");
            }

            for (int x = 0; x < map.GetLength(0); x++)
            {
                switch (mapStringRows[y][x])
                {
                    case '.':
                    {
                        map[x, y] = false;
                        break;
                    }

                    case '#':
                    {
                        map[x, y] = null;
                        break;
                    }

                    case '^':
                    {
                        map[x, y] = false;
                        guardState = new()
                        {
                            Pos = new() { X = x, Y = y },
                            Direction = Direction.North,
                        };
                        break;
                    }

                    case '>':
                    {
                        map[x, y] = false;
                        guardState = new()
                        {
                            Pos = new() { X = x, Y = y },
                            Direction = Direction.East,
                        };
                        break;
                    }

                    case 'v':
                    {
                        map[x, y] = false;
                        guardState = new()
                        {
                            Pos = new() { X = x, Y = y },
                            Direction = Direction.South,
                        };
                        break;
                    }

                    case '<':
                    {
                        map[x, y] = false;
                        guardState = new()
                        {
                            Pos = new() { X = x, Y = y },
                            Direction = Direction.West,
                        };
                        break;
                    }

                    default:
                    {
                        throw new FormatException($"Invalid Character '{mapStringRows[y][x]}'" +
                            $"at coordinate: ({x}/{y})");
                    }
                }
            }
        }

        return guardState == null
            ? throw new FormatException("unable to find guard position")
            : new(map, guardState);
    }
}
