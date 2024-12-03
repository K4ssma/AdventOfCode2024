namespace AdventOfCode2024;

using AdventOfCode2024.Day01.Task01;
using AdventOfCode2024.Day01.Task01.InputReader;
using AdventOfCode2024.Day01.Task02;
using Day01InputReader = AdventOfCode2024.Day01.InputReader;

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

                default:
                {
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

                    if (inputFileString.Trim() == string.Empty)
                    {
                        Console.WriteLine("Input File is empty");
                        return false;
                    }

                    (int, int)[] numbers = Day01InputReader.ReadInputString(inputFileString).ToArray();
                    int distance = DistanceCalculator.CalculateOverallDistance(numbers);

                    Console.WriteLine("Die Gesamtdistanz beträgt:");
                    Console.WriteLine($"{distance}\n\r");
                    return true;
                }

                case 2:
                {
                    string inputFileString = File.ReadAllText(@"..\net9.0\Day01\Input.txt");

                    if (inputFileString.Trim() == string.Empty)
                    {
                        Console.WriteLine("Input File is empty");
                        return false;
                    }

                    (int, int)[] numbers = Day01InputReader.ReadInputString(inputFileString).ToArray();
                    int similarity = SimilarityCalculator.CalculateSimilarityScore(numbers);

                    Console.WriteLine("Die Gesamt-Ähnlichkeit beträgt:");
                    Console.WriteLine($"{similarity}\n\r");
                    return true;
                }

                default:
                {
                    Console.WriteLine("Diese Aufgabe existiert (noch) nicht");
                    Console.WriteLine("Bitte versuche eine andere\r\n");
                    break;
                }
            }
        }
    }
}