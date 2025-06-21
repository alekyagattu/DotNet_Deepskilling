using System;
using System.IO;

public static class Logger
{
    public enum LogLevel
    {
        INFO,
        WARNING,
        ERROR
    }

    public static void Log(string imageName, string message, LogLevel level = LogLevel.INFO)
    {
        string fileName = $"{imageName}.log";
        string logMessage = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] [{level}] {message}";

        Console.WriteLine(logMessage);
        File.AppendAllText(fileName, logMessage + Environment.NewLine);
    }
}
