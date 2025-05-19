namespace ClassLibrary.CreationalPatterns.AbstractFactory;
using ClassLibrary.CreationalPatterns.AbstractFactory.Creator.Interface;
using ClassLibrary.CreationalPatterns.AbstractFactory.Creator.Implementation;
using ClassLibrary.CreationalPatterns.AbstractFactory.Product.Phone;
using ClassLibrary.CreationalPatterns.AbstractFactory.Product.Tablet;

public class Client
{
    public static void ClientMethod(IAbstractFactory abstractFactory)
    {
        Phone phone = abstractFactory.CreatePhone();
        Tablet tablet = abstractFactory.CreateTablet();

        Console.WriteLine("Client: Phone:");
        Console.WriteLine(phone.Vibrate());
        Console.WriteLine(phone.ButtonPressRespond());

        Console.WriteLine();

        Console.WriteLine("Client: Tablet:");
        Console.WriteLine(tablet.Vibrate());
        Console.WriteLine(tablet.ButtonPressRespond());
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("App: Launched with the Apple plant:");
        ClientMethod(new AppleFactory());

        Console.WriteLine();

        Console.WriteLine("App: Launched with the Samsung plant:");
        ClientMethod(new SamsungFactory());
    }
}