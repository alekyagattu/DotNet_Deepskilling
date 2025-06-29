using System;

class Program
{
    static void Main()
    {
        IImage image1 = new ProxyImage("photo1.png");
        IImage image2 = new ProxyImage("photo2.png");

        image1.Display(); // First load
        Console.WriteLine();

        image1.Display(); // Cached
        Console.WriteLine();

        image2.Display(); // First load
    }
}
