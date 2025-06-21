using System;

public class WordDocument : IDocument
{
    public void Open()
    {
        Console.WriteLine("Opening a Word document.");
    }

    public void Save()
    {
        Console.WriteLine("Saving Word document as .docx");
    }

    public void Export()
    {
        Console.WriteLine("Exporting Word document as PDF.");
    }
}
