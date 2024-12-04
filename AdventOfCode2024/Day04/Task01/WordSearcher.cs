namespace AdventOfCode2024.Day04.Task01;

public static class WordSearcher
{
    public static int GetXmasCount(string searchField)
    {
        string[] fieldRows = searchField.Split("\r\n");

        int count = 0;

        for (int rowIndex = 0; rowIndex < fieldRows.Length; rowIndex++)
        {
            for (int columnIndex = 0; columnIndex < fieldRows[rowIndex].Length; columnIndex++)
            {
                if (fieldRows[rowIndex][columnIndex] != 'X')
                {
                    continue;
                }

                // horizontal left to right
                if (columnIndex <= fieldRows[rowIndex].Length - 4
                    && fieldRows[rowIndex][columnIndex + 1] == 'M'
                    && fieldRows[rowIndex][columnIndex + 2] == 'A'
                    && fieldRows[rowIndex][columnIndex + 3] == 'S')
                {
                    count++;
                }

                // horizontal right to left
                if (columnIndex >= 3
                    && fieldRows[rowIndex][columnIndex - 1] == 'M'
                    && fieldRows[rowIndex][columnIndex - 2] == 'A'
                    && fieldRows[rowIndex][columnIndex - 3] == 'S')
                {
                    count++;
                }

                // vertical top to bot
                if (rowIndex <= fieldRows.Length - 4
                    && fieldRows[rowIndex + 1][columnIndex] == 'M'
                    && fieldRows[rowIndex + 2][columnIndex] == 'A'
                    && fieldRows[rowIndex + 3][columnIndex] == 'S')
                {
                    count++;
                }

                // vertical bot to top
                if (rowIndex >= 3
                    && fieldRows[rowIndex - 1][columnIndex] == 'M'
                    && fieldRows[rowIndex - 2][columnIndex] == 'A'
                    && fieldRows[rowIndex - 3][columnIndex] == 'S')
                {
                    count++;
                }

                // diagonal top-left to bot-right
                if (columnIndex <= fieldRows[rowIndex].Length - 4
                    && rowIndex <= fieldRows.Length - 4
                    && fieldRows[rowIndex + 1][columnIndex + 1] == 'M'
                    && fieldRows[rowIndex + 2][columnIndex + 2] == 'A'
                    && fieldRows[rowIndex + 3][columnIndex + 3] == 'S')
                {
                    count++;
                }

                // diagonal top-right to bot-left
                if (columnIndex >= 3
                    && rowIndex <= fieldRows.Length - 4
                    && fieldRows[rowIndex + 1][columnIndex - 1] == 'M'
                    && fieldRows[rowIndex + 2][columnIndex - 2] == 'A'
                    && fieldRows[rowIndex + 3][columnIndex - 3] == 'S')
                {
                    count++;
                }

                // diagonal bot-left to top-right
                if (columnIndex <= fieldRows[rowIndex].Length - 4
                    && rowIndex >= 3
                    && fieldRows[rowIndex - 1][columnIndex + 1] == 'M'
                    && fieldRows[rowIndex - 2][columnIndex + 2] == 'A'
                    && fieldRows[rowIndex - 3][columnIndex + 3] == 'S')
                {
                    count++;
                }

                // diagonal bot-right to top-left
                if (columnIndex >= 3
                    && rowIndex >= 3
                    && fieldRows[rowIndex - 1][columnIndex - 1] == 'M'
                    && fieldRows[rowIndex - 2][columnIndex - 2] == 'A'
                    && fieldRows[rowIndex - 3][columnIndex - 3] == 'S')
                {
                    count++;
                }
            }
        }

        return count;
    }
}
