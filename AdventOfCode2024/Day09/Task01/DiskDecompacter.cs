namespace AdventOfCode2024.Day09.Task01;

using System.Linq;

public static class DiskDecompacter
{
    public static int GetChecksum(string inputString)
    {
        int[] diskDigits = inputString
            .Select(c => int.Parse(c.ToString()))
            .ToArray();

        int checkSum = 0;
        int uncompressedPos = 0;

        int leftIndex = 0;
        int leftId = 0;

        int rightIndex = diskDigits.Length - 1;
        int rightId = diskDigits.Length / 2;

        while (leftIndex <= rightIndex)
        {
            if (leftIndex % 2 == 0)
            {
                while (diskDigits[leftIndex] > 0)
                {
                    checkSum += uncompressedPos * leftId;

                    uncompressedPos++;
                    diskDigits[leftIndex]--;
                }

                leftIndex++;
                leftId++;
                continue;
            }

            while (true)
            {
                if (diskDigits[leftIndex] <= 0)
                {
                    leftIndex++;
                    break;
                }

                if (diskDigits[rightIndex] <= 0)
                {
                    rightIndex -= 2;
                    rightId--;
                    break;
                }

                checkSum += uncompressedPos * rightId;

                uncompressedPos++;
                diskDigits[leftIndex]--;
                diskDigits[rightIndex]--;
            }
        }

        return checkSum;
    }
}
