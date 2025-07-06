using System;
using Lab3; // 👈 required for AppDbContext
#nullable enable

class Program
{
    static void Main()
    {
        using var context = new AppDbContext();
        Console.WriteLine("EF Core Lab 3 running...");
    }
}
