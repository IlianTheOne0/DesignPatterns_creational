namespace ClassLibrary.CreationalPatterns.FabricMethod.Product;

public interface ITechnic
{
    string Vibrate();
    string ButtonPressRespond();
}

public abstract class Phone : ITechnic
{
    public abstract string Vibrate();
    public abstract string ButtonPressRespond();
}

class Iphone : Phone
{
    public override string Vibrate() => "Iphone is vibrating...";
    public override string ButtonPressRespond() => "The button on Iphone was pressed. Responding...";
}

class Samsung : Phone
{
    public override string Vibrate() => "Samsung is vibrating...";
    public override string ButtonPressRespond() => "The button on Samsung was pressed. Responding...";
}