using System;
using System.IO;

public static class Logger
{
    private static readonly string _logFilePath = "log.txt";

    static Logger()
    {
        File.AppendAllText(_logFilePath, $"\n--- Session started: {DateTime.Now} ---\n");
    }

    public static void Log(string message)
    {
        string entry = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}";
        Console.WriteLine(entry);
        File.AppendAllText(_logFilePath, entry + Environment.NewLine);
    }
}
