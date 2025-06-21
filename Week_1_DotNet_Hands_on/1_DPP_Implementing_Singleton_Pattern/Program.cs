using System;

class Program
{
    static void Main(string[] args)
    {
        Logger logger = Logger.GetInstance();

        Console.WriteLine("=== Logger Started ===");
        Console.WriteLine("Enter messages to log. Type 'exit' to quit.");
        Console.WriteLine("Format: <level> <message>");
        Console.WriteLine("Example: info Application started\n");

        while (true)
        {
            Console.Write("Log> ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
                continue;

            if (input.Trim().ToLower() == "exit")
                break;

            // Split into log level and message
            string[] parts = input.Split(' ', 2, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length < 2)
            {
                Console.WriteLine("Invalid input. Format: <level> <message>");
                continue;
            }

            string level = parts[0].ToLower();
            string message = parts[1];

            // Log based on level
            switch (level)
            {
                case "info":
                    logger.Info(message);
                    break;
                case "warning":
                    logger.Warning(message);
                    break;
                case "error":
                    logger.Error(message);
                    break;
                default:
                    Console.WriteLine("Invalid level. Use info, warning, or error.");
                    break;
            }
        }

        logger.Info("Logger stopped by user.");
        Console.WriteLine("Exiting logger. Goodbye!");
    }
}
