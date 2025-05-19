namespace ClassLibrary.CreationalPatterns.FabricMethod.Creator;
using ClassLibrary.CreationalPatterns.FabricMethod.Product;

public abstract class Creator
{
    public abstract Phone FactoryMethod();

    public string VibrateOperation()
    {
        Phone product = FactoryMethod();

        string result = "Creator: The same creator's code has just woked with " + product.Vibrate();
        return result;
    }

    public string ButtonPressRespondOperation()
    {
        Phone product = FactoryMethod();

        string result = "Creator: The same creator's code has just woked with " + product.ButtonPressRespond();
        return result;
    }
}

public class IphonePlant : Creator
{
    public override Phone FactoryMethod() => new Iphone();
}

public class SamsungPlant : Creator
{
    public override Phone FactoryMethod() => new Samsung();
}