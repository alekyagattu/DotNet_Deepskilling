using System;
using System.IO;

public class Logger
{
    private static readonly Logger _instance = new Logger();
    private readonly string _logFilePath;

    private Logger()
    {
        _logFilePath = "log.txt";
        if (!File.Exists(_logFilePath))
        {
            File.WriteAllText(_logFilePath, $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] Logger initialized.{Environment.NewLine}");
        }
    }

    public static Logger GetInstance()
    {
        return _instance;
    }

    public void Log(string message, string level = "INFO")
    {
        string logEntry = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] [{level.ToUpper()}] {message}";
        Console.WriteLine(logEntry);
        File.AppendAllText(_logFilePath, logEntry + Environment.NewLine);
    }

    public void Info(string message) => Log(message, "INFO");
    public void Warning(string message) => Log(message, "WARNING");
    public void Error(string message) => Log(message, "ERROR");
}
