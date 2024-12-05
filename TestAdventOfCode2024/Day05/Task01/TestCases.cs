namespace TestAdventOfCode2024.Day05.Task01;

using System.Collections.Generic;

public static class TestCases
{
    public static IEnumerable<TestCaseData> PrintPageCases
    {
        get
        {
            yield return new TestCaseData(
                "47|53\r\n" +
                "75|29\r\n" +
                "75|53\r\n" +
                "53|29\r\n" +
                "61|53\r\n" +
                "61|29\r\n" +
                "75|47\r\n" +
                "47|61\r\n" +
                "75|61\r\n" +
                "47|29\r\n" +
                "\r\n" +
                "75,47,61,53,29").Returns(61).SetName("TestCase 01");

            yield return new TestCaseData(
                "97|13\r\n" +
                "97|61\r\n" +
                "61|13\r\n" +
                "29|13\r\n" +
                "97|29\r\n" +
                "53|29\r\n" +
                "61|53\r\n" +
                "97|53\r\n" +
                "61|29\r\n" +
                "53|13\r\n" +
                "\r\n" +
                "97,61,53,29,13").Returns(53).SetName("TestCase 02");

            yield return new TestCaseData(
                "75|29\r\n" +
                "29|13\r\n" +
                "75|13\r\n" +
                "\r\n" +
                "75,29,13").Returns(29).SetName("TestCase 03");

            yield return new TestCaseData(
                "47|53\r\n" +
                "97|61\r\n" +
                "97|47\r\n" +
                "75|53\r\n" +
                "61|53\r\n" +
                "97|53\r\n" +
                "75|47\r\n" +
                "97|75\r\n" +
                "47|61\r\n" +
                "75|61\r\n" +
                "\r\n" +
                "75,97,47,61,53").Returns(0).SetName("TestCase 04");

            yield return new TestCaseData(
                "61|13\r\n" +
                "29|13\r\n" +
                "61|29\r\n" +
                "\r\n" +
                "61,13,29").Returns(0).SetName("TestCase 05");

            yield return new TestCaseData(
                "97|13\r\n" +
                "97|47\r\n" +
                "75|29\r\n" +
                "29|13\r\n" +
                "97|29\r\n" +
                "47|13\r\n" +
                "75|47\r\n" +
                "97|75\r\n" +
                "47|29\r\n" +
                "75|13\r\n" +
                "\r\n" +
                "97,13,75,29,47").Returns(0).SetName("TestCase 06");

            yield return new TestCaseData(
                "47|53\r\n" +
                "97|13\r\n" +
                "97|61\r\n" +
                "97|47\r\n" +
                "75|29\r\n" +
                "61|13\r\n" +
                "75|53\r\n" +
                "29|13\r\n" +
                "97|29\r\n" +
                "53|29\r\n" +
                "61|53\r\n" +
                "97|53\r\n" +
                "61|29\r\n" +
                "47|13\r\n" +
                "75|47\r\n" +
                "97|75\r\n" +
                "47|61\r\n" +
                "75|61\r\n" +
                "47|29\r\n" +
                "75|13\r\n" +
                "53|13\r\n" +
                "\r\n" +
                "75,47,61,53,29\r\n" +
                "97,61,53,29,13\r\n" +
                "75,29,13\r\n" +
                "75,97,47,61,53\r\n" +
                "61,13,29\r\n" +
                "97,13,75,29,47").Returns(143).SetName("Complex Example");
        }
    }
}
