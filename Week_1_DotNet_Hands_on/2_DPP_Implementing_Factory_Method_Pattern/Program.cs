using System;

class Program
{
    static void Main(string[] args)
    {
        Logger.Log("Choose document type: word / pdf / excel");
        string? inputRaw = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(inputRaw))
        {
            Logger.Log("No input given.");
            return;
        }

        string input = inputRaw.ToLower();

        DocumentFactory? factory = input switch
        {
            "word" => new WordDocumentFactory(),
            "pdf" => new PdfDocumentFactory(),
            "excel" => new ExcelDocumentFactory(),
            _ => null
        };

        if (factory == null)
        {
            Logger.Log("Invalid document type.");
            return;
        }

        IDocument document = factory.CreateDocument();
        Logger.Log($"Created a {input} document.");

        while (true)
        {
            Logger.Log("Choose an action: open / save / export / exit");
            string? actionRaw = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(actionRaw))
            {
                Logger.Log("No action entered.");
                continue;
            }

            string action = actionRaw.ToLower();

            switch (action)
            {
                case "open":
                    document.Open();
                    Logger.Log("Action: Open document");
                    break;
                case "save":
                    document.Save();
                    Logger.Log("Action: Save document");
                    break;
                case "export":
                    document.Export();
                    Logger.Log("Action: Export document");
                    break;
                case "exit":
                    Logger.Log("Exiting application.");
                    return;
                default:
                    Logger.Log("Invalid action.");
                    break;
            }
        }
    }
}
