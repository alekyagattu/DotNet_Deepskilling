using System;

public class PdfDocument : IDocument
{
    public void Open()
    {
        Console.WriteLine("Opening a PDF document.");
    }

    public void Save()
    {
        Console.WriteLine("Saving changes to PDF.");
    }

    public void Export()
    {
        Console.WriteLine("Exporting PDF to image format.");
    }
}
