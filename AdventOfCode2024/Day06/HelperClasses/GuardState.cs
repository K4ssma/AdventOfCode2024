namespace AdventOfCode2024.Day06.HelperClasses;

public sealed record GuardState
{
    public required Vector2Int Pos { get; set; }

    public required Direction Direction { get; set; }
}
