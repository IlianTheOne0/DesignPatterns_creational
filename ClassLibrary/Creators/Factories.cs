namespace ClassLibrary.CreationalPatterns.AbstractFactory.Creator.Implementation;
using ClassLibrary.CreationalPatterns.AbstractFactory.Creator.Interface;
using ClassLibrary.CreationalPatterns.AbstractFactory.Product.Phone;
using ClassLibrary.CreationalPatterns.AbstractFactory.Product.Tablet;

public class AppleFactory : AbstractFactory
{
    public override Phone CreatePhone() => new Iphone();
    public override Tablet CreateTablet() => new Ipad();
}

public class SamsungFactory : AbstractFactory
{
    public override Phone CreatePhone() => new Samsung();
    public override Tablet CreateTablet() => new SamsungTab();
}