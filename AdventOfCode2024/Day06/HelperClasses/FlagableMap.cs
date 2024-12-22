namespace AdventOfCode2024.Day06.HelperClasses;

using System;

internal sealed class FlagableMap
{
    private readonly MapTile?[,] map;

    private GuardState guardState;

    private GuardState savedGuardState;
    private List<Vector2Int> savedTiles;

    public FlagableMap(string mapString)
    {
        string[] rowStrings = mapString.Split("\r\n");

        int rowCount = rowStrings.Length;
        int colCount = rowStrings[0].Length;

        this.map = new MapTile?[rowCount, colCount];
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
                        this.map[y, x] = new();
                        continue;
                    }

                    case '#':
                    {
                        this.map[y, x] = null;
                        continue;
                    }

                    case '^':
                    {
                        this.map[y, x] = new();
                        this.guardState = new(new(x, y), new(0, -1));
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

        this.savedGuardState = this.guardState;
        this.savedTiles = [];
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
        GuardState? nextState = this.GetNext();

        if (nextState == null)
        {
            return false;
        }

        this.guardState = nextState.Value;
        return true;
    }

    /// <summary>
    /// marks the current position of the guard if it's not already marked
    /// </summary>
    /// <returns>
    /// <para><c>true</c> when a new mark got placed</para>
    /// <para><c>false</c> when there was already a mark and therefore nothing happened</para>
    /// </returns>
    public bool MarkCurrPosIfEmpty()
    {
        MapTile tile = this.map[this.guardState.Pos.Y, this.guardState.Pos.X]!;

        if (tile.GuardDir != null)
        {
            return false;
        }

        this.savedTiles.Add(this.guardState.Pos);
        tile.MarkTile(this.guardState.Pos);
        return true;
    }

    /// <summary>
    /// checks wether the guard is in a loop or not
    /// </summary>
    public bool IsOnLoop()
    {
        MapTile currTile = this.map[this.guardState.Pos.Y, this.guardState.Pos.X]!;

        return currTile.GuardDir != null
            && currTile.GuardDir.Value.X == this.guardState.Dir.X
            && currTile.GuardDir.Value.Y == this.guardState.Dir.Y;
    }

    /// <summary>
    /// places an obstruction on the next tile the guard would move to
    /// </summary>
    /// <returns>
    /// <para><c>true</c> the obstruction was placed successfully</para>
    /// <para><c>false</c> there was no valid spot for the obstruction</para>
    /// </returns>
    public bool PlaceObstruction()
    {
        GuardState? nextState = this.GetNext();

        if (nextState == null)
        {
            return false;
        }

        this.savedTiles.Add(nextState.Value.Pos);
        this.map[nextState.Value.Pos.Y, nextState.Value.Pos.X] = null;
        return true;
    }

    /// <summary>
    /// <para>saves the current map and guard state</para>
    /// <para>if there is an already saved state, it gets overridden</para>
    /// </summary>
    public void SaveState()
    {
        this.savedGuardState = this.guardState;
        this.savedTiles = [];
    }

    /// <summary>
    /// <para>restores the last saved map and guard state</para>
    /// <para>if there was no state saved everything gets reset to their initial value</para>
    /// </summary>
    public void LoadSavedState()
    {
        this.guardState = this.savedGuardState;

        foreach (Vector2Int pos in this.savedTiles)
        {
            this.map[pos.Y, pos.X] = new();
        }
    }

    private GuardState? GetNext()
    {
        Vector2Int nextDir = this.guardState.Dir;

        for (int i = 0; i < 3; i++)
        {
            Vector2Int nextPos = new(this.guardState.Pos.X + nextDir.X, this.guardState.Pos.Y + nextDir.Y);

            if (nextPos.X < 0
                || nextPos.X >= this.map.GetLength(1)
                || nextPos.Y < 0
                || nextPos.Y >= this.map.GetLength(0))
            {
                return null;
            }

            if (this.map[nextPos.Y, nextPos.X] != null)
            {
                return new(nextPos, nextDir);
            }

            nextDir = new(-nextDir.Y, nextDir.X);
        }

        throw new InvalidOperationException("guard is surrounded by obstructions and therefore can't move");
    }

    private sealed class MapTile
    {
        public Vector2Int? GuardDir { get; private set; } = null;

        /// <summary>
        /// save the direction of the guard standing on this tile
        /// </summary>
        /// <param name="guardDir">
        /// the direction that should get saved by this tile
        /// </param>
        /// <returns>
        /// <para><c>true</c> the tile got marked successfully</para>
        /// <para><c>false</c> this tile was already marked and therefore nothing happened</para>
        /// </returns>
        public bool MarkTile(Vector2Int guardDir)
        {
            if (this.GuardDir != null)
            {
                return false;
            }

            this.GuardDir = guardDir;
            return true;
        }
    }
}
