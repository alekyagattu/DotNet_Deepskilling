public class ProxyImage : IImage
{
    private RealImage? realImage;
    private string fileName;

    public ProxyImage(string fileName)
    {
        this.fileName = fileName;
    }

    public void Display()
    {
        if (realImage == null)
        {
            Logger.Log(fileName, $"Lazy loading image.", Logger.LogLevel.INFO);
            realImage = new RealImage(fileName);
        }
        else
        {
            Logger.Log(fileName, $"Using cached image.", Logger.LogLevel.INFO);
        }

        realImage.Display();
    }
}
