using System;
using System.IO;

public static class Logger
{
    private static readonly string logPath = "employee_log.txt";

    static Logger()
    {
        File.AppendAllText(logPath, $"\n--- Log Started at {DateTime.Now} ---\n");
    }

    public static void Log(string message)
    {
        string logMessage = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}";
        Console.WriteLine(logMessage);
        File.AppendAllText(logPath, logMessage + Environment.NewLine);
    }
}
