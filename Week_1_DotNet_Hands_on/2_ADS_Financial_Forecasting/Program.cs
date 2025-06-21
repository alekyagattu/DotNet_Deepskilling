using System;
using System.Diagnostics;
using System.IO;

class Program
{
    static double CalculateForecast(double amount, double rate, int years)
    {
        // Base case
        if (years == 0)
            return amount;

        // Recursive case: compound annually
        return CalculateForecast(amount * (1 + rate / 100), rate, years - 1);
    }

    static void Main()
    {
        Console.Write("Enter initial amount: ");
        double initialAmount = double.Parse(Console.ReadLine() ?? "0");

        Console.Write("Enter number of years to forecast: ");
        int years = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("How many growth rates do you want to compare? ");
        int rateCount = int.Parse(Console.ReadLine() ?? "0");

        double[] rates = new double[rateCount];
        for (int i = 0; i < rateCount; i++)
        {
            Console.Write($"Enter growth rate {i + 1} (as %): ");
            rates[i] = double.Parse(Console.ReadLine() ?? "0");
        }

        string filePath = "forecast.txt";
        using StreamWriter writer = new StreamWriter(filePath);
        writer.WriteLine($"📈 Forecast for Initial Amount: ₹{initialAmount} over {years} years:");
        writer.WriteLine(new string('-', 50));

        var stopwatch = Stopwatch.StartNew();

        foreach (double rate in rates)
        {
            double result = CalculateForecast(initialAmount, rate, years);
            string line = $"Growth Rate {rate}% → ₹{result:F2}";
            Console.WriteLine(line);
            writer.WriteLine(line);
        }

        stopwatch.Stop();

        Console.WriteLine("✔ Forecast saved to forecast.txt");
        writer.WriteLine(new string('-', 50));
        writer.WriteLine($"⌛ Time Complexity: O(n), Time Taken: {stopwatch.Elapsed.TotalMilliseconds:F4} ms");
    }
}

