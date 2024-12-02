﻿namespace AdventOfCode2024;

using AdventOfCode2024.Day01.Task01;
using AdventOfCode2024.Day01.Task02;
using AdventOfCode2024.Day02.Task01;
using Day01InputReader = AdventOfCode2024.Day01.InputReader;
using Day02InputReader = AdventOfCode2024.Day02.InputReader;

public static class Program
{
    private const string ExitCode = "e";

    public static void Main(string[] args)
    {
        while (true)
        {
            int? inputNum = GetInput("Bitte gebe die Zahl des Türchens ein, dass du ausführen möchtest");

            if (!inputNum.HasValue)
            {
                return;
            }

            switch (inputNum.Value)
            {
                case 1:
                {
                    if (!OpenDoor01())
                    {
                        return;
                    }

                    break;
                }

                case 2:
                {
                    if (!OpenDoor02())
                    {
                        return;
                    }

                    break;
                }

                default:
                {
                    Console.Clear();

                    Console.WriteLine("Dieses Türchen existiert (noch) nicht");
                    Console.WriteLine("Bitte versuche ein anderes\r\n");
                    break;
                }
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

    public static bool OpenDoor01()
    {
        while (true)
        {
            int? inputNum = GetInput("Gebe die Zahl, der Aufgabe ein, die du ausführen möchtest");

            if (!inputNum.HasValue)
            {
                return false;
            }

            switch (inputNum.Value)
            {
                case 1:
                {
                    string inputFileString = File.ReadAllText(@"..\net9.0\Day01\Input.txt");

                    (int, int)[] numbers = Day01InputReader.ReadInputString(inputFileString).ToArray();
                    int distance = DistanceCalculator.CalculateOverallDistance(numbers);

                    Console.WriteLine("Die Gesamtdistanz beträgt:");
                    Console.WriteLine($"{distance}\n\r");
                    return true;
                }

                case 2:
                {
                    string inputFileString = File.ReadAllText(@"..\net9.0\Day01\Input.txt");
                    (int, int)[] numbers = Day01InputReader.ReadInputString(inputFileString).ToArray();
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
                    break;
                }
            }
        }
    }

    public static bool OpenDoor02()
    {
        while (true)
        {
            int? inputNum = GetInput("Gebe die Zahl, der Aufgabe ein, die du ausführen möchtest");

            if (!inputNum.HasValue)
            {
                return false;
            }

            switch (inputNum.Value)
            {
                case 1:
                {
                    string inputFileString = File.ReadAllText(@"..\net9.0\Day02\Input.txt");

                    int[][] reports = Day02InputReader
                        .ReadInputString(inputFileString)
                        .Select(report => report.ToArray())
                        .ToArray();

                    int safeReportCount = ReportAnalyzer.GetNumOfSafeReports(reports);

                    Console.WriteLine("Anzahl der sicheren Reports:");
                    Console.WriteLine($"{safeReportCount}\r\n");
                    return true;
                }

                default:
                {
                    Console.Clear();

                    Console.WriteLine("Diese Aufgabe existiert (noch) nicht");
                    Console.WriteLine("Bitte versuche eine andere\r\n");
                    break;
                }
            }
        }
    }
}