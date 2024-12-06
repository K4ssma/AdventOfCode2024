namespace AdventOfCode2024.Day06.HelperClasses;

public struct Vector2Int(int x, int y)
{
    public required int X { get; set; } = x;

    public required int Y { get; set; } = y;
}
