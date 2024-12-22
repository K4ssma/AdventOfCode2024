namespace AdventOfCode2024.Day06.HelperClasses;

using System;

internal sealed class FlagableMap
{
    private readonly bool?[,] map;
    private Vector2Int guardPos;
    private Vector2Int guardDir;

    public FlagableMap(string mapString)
    {
        string[] rowStrings = mapString.Split("\r\n");

        int rowCount = rowStrings.Length;
        int colCount = rowStrings[0].Length;

        this.map = new bool?[rowCount, colCount];
        bool foundGuardPos = false;

        for (int y = 0; y < rowCount; y++)
        {
            if (rowStrings[y].Length != colCount)
            {
                throw new FormatException("each row needs to have the same length");
            }

            for (int x = 0; x < colCount; x++)
            {
                switch (rowStrings[y][x])
                {
                    case '.':
                    {
                        this.map[y, x] = false;
                        continue;
                    }

                    case '#':
                    {
                        this.map[y, x] = null;
                        continue;
                    }

                    case '^':
                    {
                        this.map[y, x] = false;
                        this.guardPos = new(x, y);
                        this.guardDir = new(0, -1);
                        foundGuardPos = true;
                        continue;
                    }

                    default:
                    {
                        throw new FormatException($"invalid char '{rowStrings[y][x]}' at x={x} y={y}");
                    }
                }
            }
        }

        if (!foundGuardPos)
        {
            throw new FormatException("unable find guard position");
        }
    }

    /// <summary>
    /// <para>moves the guard one step forward in the direction it is currently facing</para>
    /// <para>if the next field is obstructed the guard gets rotated clockwise and then moves forward</para>
    /// </summary>
    /// <returns>
    /// <para><c>true</c> the guard successfully moved one step</para>
    /// <para><c>false</c> the guard left the map</para>
    /// </returns>
    /// <exception cref="InvalidOperationException">
    /// the guard is surrounded by obstructions and therefore can't move
    /// </exception>
    public bool MoveNext()
    {
        Vector2Int nextDir = this.guardDir;

        for (int i = 0; i < 3; i++)
        {
            Vector2Int nextPos = new(this.guardPos.X + nextDir.X, this.guardPos.Y + nextDir.Y);

            if (nextPos.X < 0
                || nextPos.X >= this.map.GetLength(1)
                || nextPos.Y < 0
                || nextPos.Y >= this.map.GetLength(0))
            {
                return false;
            }

            if (this.map[nextPos.Y, nextPos.X] != null)
            {
                this.guardPos = nextPos;
                this.guardDir = nextDir;
                return true;
            }

            nextDir = new(-nextDir.Y, nextDir.X);
        }

        throw new InvalidOperationException("guard is surrounded by obstructions and therefore can't move");
    }

    /// <summary>
    /// marks the current position of the guard if it's not already marked
    /// </summary>
    /// <returns>
    /// <para><c>true</c> when a new mark got placed</para>
    /// <para><c>false</c> when there was already a mark and therefore no mark was placed</para>
    /// </returns>
    public bool MarkCurrPosIfEmpty()
    {
        if (this.map[this.guardPos.Y, this.guardPos.X] == true)
        {
            return false;
        }

        this.map[this.guardPos.Y, this.guardPos.X] = true;
        return true;
    }
}
