public class RealImage : IImage
{
    private string fileName;

    public RealImage(string fileName)
    {
        this.fileName = fileName;
        LoadFromServer();
    }

    private void LoadFromServer()
    {
        Logger.Log(fileName, $"Loading image from remote server: {fileName}", Logger.LogLevel.INFO);
    }

    public void Display()
    {
        Logger.Log(fileName, $"Displaying image: {fileName}", Logger.LogLevel.INFO);
    }
}
