namespace AdventOfCode2024.Day06.HelperClasses;

using AdventOfCode2024.HelperClasses;

internal struct GuardState(Vector2Int position, Vector2Int direction)
{
    public Vector2Int Pos = position;
    public Vector2Int Dir = direction;
}
