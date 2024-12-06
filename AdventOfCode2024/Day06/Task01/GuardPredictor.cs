namespace AdventOfCode2024.Day06.Task01;

using System;
using AdventOfCode2024.Day06.HelperClasses;

public static class GuardPredictor
{
    public static int PredictGuardLocations(bool?[,] map, GuardState currGuardState)
    {
        int locationCounter = 1;
        GuardState? nextGuardState = GetNextGuardState(map, currGuardState);

        while (nextGuardState != null)
        {
            if (map[currGuardState.Pos.X, currGuardState.Pos.Y] == false)
            {
                map[currGuardState.Pos.X, currGuardState.Pos.Y] = true;
                locationCounter++;
            }

            currGuardState = nextGuardState;
            nextGuardState = GetNextGuardState(map, currGuardState);
        }

        return locationCounter;
    }

    private static GuardState? GetNextGuardState(bool?[,] map, GuardState currGuardState)
    {
        Direction nextDirection = currGuardState.Direction;
        Vector2Int nextPos;

        for (int i = 0; i < 4; i++)
        {
            switch (nextDirection)
            {
                case Direction.North:
                {
                    nextPos = new()
                    {
                        X = currGuardState.Pos.X,
                        Y = currGuardState.Pos.Y - 1,
                    };
                    break;
                }

                case Direction.East:
                {
                    nextPos = new()
                    {
                        X = currGuardState.Pos.X + 1,
                        Y = currGuardState.Pos.Y,
                    };
                    break;
                }

                case Direction.South:
                {
                    nextPos = new()
                    {
                        X = currGuardState.Pos.X,
                        Y = currGuardState.Pos.Y + 1,
                    };
                    break;
                }

                case Direction.West:
                {
                    nextPos = new()
                    {
                        X = currGuardState.Pos.X - 1,
                        Y = currGuardState.Pos.Y,
                    };
                    break;
                }

                default:
                {
                    throw new NotSupportedException($"{nameof(Direction)} with value '{nextDirection}'" +
                        "is not supported");
                }
            }

            if (nextPos.X < 0
                || nextPos.Y < 0
                || nextPos.X >= map.GetLength(0)
                || nextPos.Y >= map.GetLength(1))
            {
                return null;
            }

            if (map[nextPos.X, nextPos.Y] == null)
            {
                nextDirection = (Direction)(((int)nextDirection + 1) % 4);
                continue;
            }

            return new()
            {
                Pos = nextPos,
                Direction = nextDirection,
            };
        }

        throw new ArgumentException("guard is unable to moce, because it is surrounded by obstacles");
    }
}
