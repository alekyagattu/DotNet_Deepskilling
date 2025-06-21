using System;

public class ExcelDocument : IDocument
{
    public void Open()
    {
        Console.WriteLine("Opening an Excel spreadsheet.");
    }

    public void Save()
    {
        Console.WriteLine("Saving Excel spreadsheet as .xlsx");
    }

    public void Export()
    {
        Console.WriteLine("Exporting Excel sheet to CSV.");
    }
}
