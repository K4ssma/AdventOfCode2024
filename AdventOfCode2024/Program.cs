﻿namespace AdventOfCode2024;

using AdventOfCode2024.Day01.Task01;
using AdventOfCode2024.Day01.Task02;
using AdventOfCode2024.Day02.Task01;
using AdventOfCode2024.Day02.Task02;
using AdventOfCode2024.Day03.Task01;
using AdventOfCode2024.Day03.Task02;
using AdventOfCode2024.Day04.Task01;
using AdventOfCode2024.Day04.Task02;
using AdventOfCode2024.Day05.Task01;
using AdventOfCode2024.Day05.Task02;
using AdventOfCode2024.Day06.Task01;
using AdventOfCode2024.Day06.Task02;
using AdventOfCode2024.Day07.Task01;
using AdventOfCode2024.Day07.Task02;
using AdventOfCode2024.Day08.Task01;
using AdventOfCode2024.Day08.Task02;
using AdventOfCode2024.Day09.Task01;
using AdventOfCode2024.HelperClasses;
using Day01InputReader = AdventOfCode2024.Day01.InputReader;
using Day02InputReader = AdventOfCode2024.Day02.InputReader;
using Day07InputReader = AdventOfCode2024.Day07.InputReader;
using Day08InputReader = AdventOfCode2024.Day08.InputReader;

public static class Program
{
    private const string ExitCode = "e";

    public static void Main(string[] args)
    {
        while (true)
        {
            int? doorNum = GetInput("Bitte gebe die Zahl des Türchens ein, dass du ausführen möchtest");

            if (!doorNum.HasValue)
            {
                return;
            }

            Func<int, bool> doorOpener;

            switch (doorNum.Value)
            {
                case 1:
                {
                    doorOpener = OpenDoor01;
                    break;
                }

                case 2:
                {
                    doorOpener = OpenDoor02;
                    break;
                }

                case 3:
                {
                    doorOpener = OpenDoor03;
                    break;
                }

                case 4:
                {
                    doorOpener = OpenDoor04;
                    break;
                }

                case 5:
                {
                    doorOpener = OpenDoor05;
                    break;
                }

                case 6:
                {
                    doorOpener = OpenDoor06;
                    break;
                }

                case 7:
                {
                    doorOpener = OpenDoor07;
                    break;
                }

                case 8:
                {
                    doorOpener = OpenDoor08;
                    break;
                }

                case 9:
                {
                    doorOpener = OpenDoor09;
                    break;
                }

                default:
                {
                    Console.Clear();

                    Console.WriteLine("Dieses Türchen existiert (noch) nicht");
                    Console.WriteLine("Bitte versuche ein anderes\r\n");
                    continue;
                }
            }

            int? taskNum = GetInput("Bitte gebe die Zahl der Aufgabe ein, die du ausführen möchtest");

            if (!taskNum.HasValue)
            {
                return;
            }

            if (!doorOpener(taskNum.Value))
            {
                return;
            }
        }
    }

    public static int? GetInput(string consoleMessage)
    {
        while (true)
        {
            Console.WriteLine(consoleMessage);
            Console.WriteLine($"Um das Programm zu beenden" +
                $" gebe zu einem beliebigen Eingabe-Zeitpunkt '{ExitCode}' ein");

            string? inputString = Console.ReadLine();

            if (inputString != null
                && inputString.Equals(ExitCode, StringComparison.CurrentCultureIgnoreCase))
            {
                return null;
            }

            if (int.TryParse(inputString, out int inputNum))
            {
                return inputNum;
            }

            Console.Clear();

            Console.WriteLine("Ungültige Eingabe bitte Versuche es nocheinmal\r\n");
        }
    }

    public static bool OpenDoor01(int taskNum)
    {
        string inputFileString = File.ReadAllText(@"..\net9.0\Day01\Input.txt");

        if (inputFileString.Trim() == string.Empty)
        {
            Console.WriteLine("Input File is empty");
            return false;
        }

        (int, int)[] numbers = Day01InputReader.ReadInputString(inputFileString).ToArray();

        switch (taskNum)
        {
            case 1:
            {
                int distance = DistanceCalculator.CalculateOverallDistance(numbers);

                Console.WriteLine("Die Gesamtdistanz beträgt:");
                Console.WriteLine($"{distance}\n\r");
                return true;
            }

            case 2:
            {
                int similarity = SimilarityCalculator.CalculateSimilarityScore(numbers);

                Console.WriteLine("Die Gesamt-Ähnlichkeit beträgt:");
                Console.WriteLine($"{similarity}\n\r");
                return true;
            }

            default:
            {
                Console.Clear();

                Console.WriteLine("Diese Aufgabe existiert (noch) nicht");
                Console.WriteLine("Bitte versuche eine andere\r\n");
                return true;
            }
        }
    }

    public static bool OpenDoor02(int taskNum)
    {
        string inputFileString = File.ReadAllText(@"..\net9.0\Day02\Input.txt");

        if (inputFileString.Trim() == string.Empty)
        {
            Console.WriteLine("Input File is empty");
            return false;
        }

        int[][] reports = Day02InputReader
            .ReadInputString(inputFileString)
            .Select(report => report.ToArray())
            .ToArray();

        int safeReportCount;

        switch (taskNum)
        {
            case 1:
            {
                safeReportCount = ReportAnalyzer.GetNumOfSafeReports(reports);
                break;
            }

            case 2:
            {
                safeReportCount = ProblemDampener.GetNumOfSafeReports(reports);
                break;
            }

            default:
            {
                Console.Clear();

                Console.WriteLine("Diese Aufgabe existiert (noch) nicht");
                Console.WriteLine("Bitte versuche eine andere\r\n");
                return true;
            }
        }

        Console.WriteLine("Anzahl der sicheren Reports:");
        Console.WriteLine($"{safeReportCount}\r\n");
        return true;
    }

    public static bool OpenDoor03(int taskNum)
    {
        string inputFileString = File.ReadAllText(@"..\net9.0\Day03\Input.txt");

        if (inputFileString.Trim() == string.Empty)
        {
            Console.WriteLine("Input File is empty");
            return false;
        }

        int result;

        switch (taskNum)
        {
            case 1:
            {
                result = InstructionScanner.GetInstructionResult(inputFileString);
                break;
            }

            case 2:
            {
                result = ConditionalInstructionScanner.GetInstructionResult(inputFileString);
                break;
            }

            default:
            {
                Console.Clear();

                Console.WriteLine("Diese Aufgabe existiert (noch) nicht");
                Console.WriteLine("Bitte versuche eine andere\r\n");
                return true;
            }
        }

        Console.WriteLine("Ergebniss der Computer-Anweisung");
        Console.WriteLine($"{result}\r\n");
        return true;
    }

    public static bool OpenDoor04(int taskNum)
    {
        string inputFileString = File.ReadAllText(@"..\net9.0\Day04\Input.txt");

        if (inputFileString.Trim() == string.Empty)
        {
            Console.WriteLine("Input File is empty");
            return false;
        }

        int count;

        switch (taskNum)
        {
            case 1:
            {
                count = WordSearcher.GetXmasCount(inputFileString);
                break;
            }

            case 2:
            {
                count = XmasFinder.GetXMasCount(inputFileString);
                break;
            }

            default:
            {
                Console.Clear();

                Console.WriteLine("Diese Aufgabe existiert (noch) nicht");
                Console.WriteLine("Bitte versuche eine andere\r\n");
                return true;
            }
        }

        Console.WriteLine("Anzahl:");
        Console.WriteLine($"{count}\r\n");
        return true;
    }

    public static bool OpenDoor05(int taskNum)
    {
        string inputFileString = File.ReadAllText(@"..\net9.0\Day05\Input.txt");

        if (inputFileString.Trim() == string.Empty)
        {
            Console.WriteLine("Input File is empty");
            return false;
        }

        int sum;

        switch (taskNum)
        {
            case 1:
            {
                sum = PrintValidator.GetValidMiddleSum(inputFileString);
                break;
            }

            case 2:
            {
                sum = PrintCorrector.GetCorrectedMiddleSum(inputFileString);
                break;
            }

            default:
            {
                Console.Clear();

                Console.WriteLine("Diese Aufgabe existiert (noch) nicht");
                Console.WriteLine("Bitte versuche eine andere\r\n");
                return true;
            }
        }

        Console.WriteLine("Summe der validen Druck abfolgen:");
        Console.WriteLine($"{sum}\r\n");
        return true;
    }

    public static bool OpenDoor06(int taskNum)
    {
        string inputFileString = File.ReadAllText(@"..\net9.0\Day06\Input.txt");

        if (inputFileString.Trim() == string.Empty)
        {
            Console.WriteLine("Input File is empty");
            return false;
        }

        int count;

        switch (taskNum)
        {
            case 1:
            {
                count = GuardPredictor.PredictGuardPositions(inputFileString);
                break;
            }

            case 2:
            {
                count = ObstructionPlacer.GetPossibleObstructionCount(inputFileString);
                break;
            }

            default:
            {
                Console.Clear();

                Console.WriteLine("Diese Aufgabe existiert (noch) nicht");
                Console.WriteLine("Bitte versuche eine andere\r\n");
                return true;
            }
        }

        Console.WriteLine("Anzahl:");
        Console.WriteLine($"{count}\r\n");
        return true;
    }

    public static bool OpenDoor07(int taskNum)
    {
        string inputFileString = File.ReadAllText(@"..\net9.0\Day07\Input.txt");

        if (inputFileString.Trim() == string.Empty)
        {
            Console.WriteLine("Input File is empty");
            return false;
        }

        IEnumerable<(long, IEnumerable<int>)> equations = Day07InputReader.ReadInputString(inputFileString);
        long calibrationResult;

        switch (taskNum)
        {
            case 1:
            {
                calibrationResult = Calibrator.GetCalibrationResult(equations);
                break;
            }

            case 2:
            {
                calibrationResult = ImprovedCalibrator.GetCalibrationResult(equations);
                break;
            }

            default:
            {
                Console.Clear();

                Console.WriteLine("Diese Aufgabe existiert (noch) nicht");
                Console.WriteLine("Bitte versuche eine andere\r\n");
                return true;
            }
        }

        Console.WriteLine("Kalibrierungs-Ergebniss:");
        Console.WriteLine($"{calibrationResult}\r\n");
        return true;
    }

    public static bool OpenDoor08(int taskNum)
    {
        string inputFileString = File.ReadAllText(@"..\net9.0\Day08\Input.txt");

        if (inputFileString.Trim() == string.Empty)
        {
            Console.WriteLine("Input File is empty");
            return false;
        }

        (Vector2Int, Dictionary<char, List<Vector2Int>>) antennaSets = Day08InputReader
            .ReadInputString(inputFileString);
        int nodeCount;

        switch (taskNum)
        {
            case 1:
            {
                nodeCount = AntinodeDetector.CountUniqueAntinodeSpots(antennaSets.Item1, antennaSets.Item2);
                break;
            }

            case 2:
            {
                nodeCount = CorrectedNodeDetector.GetNodeCount(antennaSets.Item1, antennaSets.Item2);
                break;
            }

            default:
            {
                Console.Clear();

                Console.WriteLine("Diese Aufgabe existiert (noch) nicht");
                Console.WriteLine("Bitte versuche eine andere\r\n");
                return true;
            }
        }

        Console.WriteLine("Antinode Anzahl:");
        Console.WriteLine($"{nodeCount}\r\n");
        return true;
    }

    public static bool OpenDoor09(int taskNum)
    {
        string inputFileString = File.ReadAllText(@"..\net9.0\Day09\Input.txt");

        if (inputFileString.Trim() == string.Empty)
        {
            Console.WriteLine("Input File is empty");
            return false;
        }

        ulong checkSum;

        switch (taskNum)
        {
            case 1:
            {
                checkSum = DiskDecompacter.GetChecksum(inputFileString);
                break;
            }

            default:
            {
                Console.Clear();

                Console.WriteLine("Diese Aufgabe existiert (noch) nicht");
                Console.WriteLine("Bitte versuche eine andere\r\n");
                return true;
            }
        }

        Console.WriteLine("Checksumme:");
        Console.WriteLine($"{checkSum}\r\n");
        return true;
    }
}