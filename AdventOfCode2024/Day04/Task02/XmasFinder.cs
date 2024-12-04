namespace AdventOfCode2024.Day04.Task02;

public static class XmasFinder
{
    public static int GetXMasCount(string searchField)
    {
        string[] rows = searchField.Split("\r\n");

        int count = 0;

        for (int rowIndex = 1; rowIndex < rows.Length - 1; rowIndex++)
        {
            for (int columnIndex = 1; columnIndex < rows[rowIndex].Length - 1; columnIndex++)
            {
                if (rows[rowIndex][columnIndex] != 'A')
                {
                    continue;
                }

                if (rows[rowIndex - 1][columnIndex - 1] == 'M'
                    && rows[rowIndex + 1][columnIndex + 1] == 'S')
                {
                    // M..
                    // .A.
                    // ..S
                    if (rows[rowIndex - 1][columnIndex + 1] == 'M'
                        && rows[rowIndex + 1][columnIndex - 1] == 'S')
                    {
                        // ..M
                        // .A.
                        // S..
                        count++;
                    }
                    else if (rows[rowIndex - 1][columnIndex + 1] == 'S'
                        && rows[rowIndex + 1][columnIndex - 1] == 'M')
                    {
                        // ..S
                        // .A.
                        // M..
                        count++;
                    }
                }
                else if (rows[rowIndex - 1][columnIndex - 1] == 'S'
                    && rows[rowIndex + 1][columnIndex + 1] == 'M')
                {
                    // S..
                    // .A.
                    // ..M
                    if (rows[rowIndex - 1][columnIndex + 1] == 'M'
                        && rows[rowIndex + 1][columnIndex - 1] == 'S')
                    {
                        // ..M
                        // .A.
                        // S..
                        count++;
                    }
                    else if (rows[rowIndex - 1][columnIndex + 1] == 'S'
                        && rows[rowIndex + 1][columnIndex - 1] == 'M')
                    {
                        // ..S
                        // .A.
                        // M..
                        count++;
                    }
                }
            }
        }

        return count;
    }
}
