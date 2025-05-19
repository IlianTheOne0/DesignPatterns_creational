namespace ClassLibrary.CreationalPatterns.FabricMethod;
using ClassLibrary.CreationalPatterns.FabricMethod.Creator;

public class Client
{
    public static void ClientMethod(Creator.Creator creator)
    {
        Console.WriteLine(creator.VibrateOperation());
        Console.WriteLine(creator.ButtonPressRespondOperation());
    }

    public static void Main(string[] args)
    {
        IphonePlant iphonePlant = new IphonePlant();
        Console.WriteLine("App: Launched with the IPhone plant:");
        ClientMethod(iphonePlant);
        
        Console.WriteLine();

        SamsungPlant samsungPlant = new SamsungPlant();
        Console.WriteLine("App: Launched with the Samsung plant:");
        ClientMethod(samsungPlant);
    }
}