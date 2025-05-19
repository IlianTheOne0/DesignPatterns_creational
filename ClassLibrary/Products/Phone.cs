namespace ClassLibrary.CreationalPatterns.AbstractFactory.Product.Phone;
using ClassLibrary.CreationalPatterns.AbstractFactory.Product.Interface;

public abstract class Phone : ITechnic
{
    public abstract string Vibrate();
    public abstract string ButtonPressRespond();
}

public class Iphone : Phone
{
    public override string Vibrate() => "Iphone is vibrating...";
    public override string ButtonPressRespond() => "The button on Iphone was pressed. Responding...";
}

public class Samsung : Phone
{
    public override string Vibrate() => "Samsung is vibrating...";
    public override string ButtonPressRespond() => "The button on Samsung was pressed. Responding...";
}