namespace ClassLibrary.CreationalPatterns.Builder.Builder;
using ClassLibrary.CreationalPatterns.Builder.Product;

public interface IBuilder<T1, T2>
{
    (T1, T2) AddFlight();
    (T1, T2) AddHotel();
    (T1, T2) AddTours();
    (T1, T2) AddMeals();
    (T1, T2) AddCarRental();

    (T1, T2) RemoveFlight();
    (T1, T2) RemoveHotel();
    (T1, T2) RemoveTours();
    (T1, T2) RemoveMeals();
    (T1, T2) RemoveCarRental();
}

public abstract class Builder<T1, T2> : IBuilder<T1, T2>
{
    protected virtual string _GetInfo(string action, string part) => $"{action} {part}";
    protected Product<T1>? _product { get; set; }

    protected const string _flightString = "Flight";
    protected const string _hotelString = "Hotel";
    protected const string _toursString = "Tours";
    protected const string _mealsString = "Meals";
    protected const string _carRentalString = "Car ";

    protected const string _minimumString = "The cheapest";
    protected const string _normalString = "Normal in cost";
    protected const string _maximumString = "The most expensive";

    public abstract (T1, T2) AddFlight();
    public abstract (T1, T2) AddHotel();
    public abstract (T1, T2) AddTours();
    public abstract (T1, T2) AddMeals();
    public abstract (T1, T2) AddCarRental();

    public abstract (T1, T2) RemoveFlight();
    public abstract (T1, T2) RemoveHotel();
    public abstract (T1, T2) RemoveTours();
    public abstract (T1, T2) RemoveMeals();
    public abstract (T1, T2) RemoveCarRental();
}
