namespace ClassLibrary.CreationalPatterns.Builder.NDirector;
using ClassLibrary.CreationalPatterns.Builder.Builder;

public class Director
{
    private IBuilder<string, string>? _builder;

    public Director(IBuilder<string, string>? builder) => _builder = builder;

    public string CreateMinimumPackage()
    {
        if (_builder == null) { return string.Empty; }

        (string flightResult, _) = _builder.AddFlight();
        (string hotelResult, _) = _builder.AddHotel();

        return $"{flightResult}\n{hotelResult}";
    }

    public string CreateNormalPackage()
    {
        if (_builder == null) { return string.Empty; }

        (string flightResult, _) = _builder.AddFlight();
        (string hotelResult, _) = _builder.AddHotel();
        (string mealsResult, _) = _builder.AddMeals();

        return $"{flightResult}\n{hotelResult}\n{mealsResult}";
    }

    public string CreateMaximumPackage()
    {
        if (_builder == null) { return string.Empty; }

        (string flightResult, _) = _builder.AddFlight();
        (string hotelResult, _) = _builder.AddHotel();
        (string mealsResult, _) = _builder.AddMeals();
        (string toursResult, _) = _builder.AddTours();
        (string carRentalResult, _) = _builder.AddCarRental();

        return $"{flightResult}\n{hotelResult}\n{mealsResult}\n{toursResult}\n{carRentalResult}";
    }

    public string DeleteMinimumPackage()
    {
        if (_builder == null) { return string.Empty; }

        (string flightResult, _) = _builder.RemoveFlight();
        (string hotelResult, _) = _builder.RemoveHotel();

        return $"{flightResult}\n{hotelResult}";
    }

    public string DeleteNormalPackage()
    {
        if (_builder == null) { return string.Empty; }

        (string flightResult, _) = _builder.RemoveFlight();
        (string hotelResult, _) = _builder.RemoveHotel();
        (string mealsResult, _) = _builder.RemoveMeals();

        return $"{flightResult}\n{hotelResult}\n{mealsResult}";
    }

    public string DeleteMaximumPackage()
    {
        if (_builder == null) { return string.Empty; }

        (string flightResult, _) = _builder.RemoveFlight();
        (string hotelResult, _) = _builder.RemoveHotel();
        (string mealsResult, _) = _builder.RemoveMeals();
        (string toursResult, _) = _builder.RemoveTours();
        (string carRentalResult, _) = _builder.RemoveCarRental();

        return $"{flightResult}\n{hotelResult}\n{mealsResult}\n{toursResult}\n{carRentalResult}";
    }
}