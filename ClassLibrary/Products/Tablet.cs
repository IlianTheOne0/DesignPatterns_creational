namespace ClassLibrary.CreationalPatterns.AbstractFactory.Product.Tablet;
using ClassLibrary.CreationalPatterns.AbstractFactory.Product.Interface;

public abstract class Tablet : ITechnic
{
    public abstract string Vibrate();
    public abstract string ButtonPressRespond();
}

public class Ipad : Tablet
{
    public override string Vibrate() => "IPad is vibrating...";
    public override string ButtonPressRespond() => "The button on IPad was pressed. Responding...";
}

public class SamsungTab : Tablet
{
    public override string Vibrate() => "Samsung Tab is vibrating...";
    public override string ButtonPressRespond() => "The button on Samsung Tab was pressed. Responding...";
}