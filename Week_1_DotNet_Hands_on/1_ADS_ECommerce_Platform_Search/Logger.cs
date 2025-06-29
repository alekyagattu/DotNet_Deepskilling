using System;
using System.IO;

public static class Logger
{
    private static readonly string resultFile = "SearchResults.txt";

    public static void LogResult(string content)
    {
        Console.WriteLine(content);
        File.AppendAllText(resultFile, content + Environment.NewLine);
    }

    public static void LogHeader(string header)
    {
        File.WriteAllText(resultFile, header + Environment.NewLine);
        Console.WriteLine(header);
    }

    public static void LogFooter()
    {
        string footer = $"🕒 Generated at: {DateTime.Now}";
        File.AppendAllText(resultFile, footer + Environment.NewLine);
        Console.WriteLine(footer);
    }
}
