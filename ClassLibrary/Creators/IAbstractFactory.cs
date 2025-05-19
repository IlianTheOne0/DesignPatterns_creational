namespace ClassLibrary.CreationalPatterns.AbstractFactory.Creator.Interface;
using ClassLibrary.CreationalPatterns.AbstractFactory.Product.Phone;
using ClassLibrary.CreationalPatterns.AbstractFactory.Product.Tablet;

public interface IAbstractFactory
{
    Phone CreatePhone();
    Tablet CreateTablet();
}

public abstract class AbstractFactory : IAbstractFactory
{
    public abstract Phone CreatePhone();
    public abstract Tablet CreateTablet();
}