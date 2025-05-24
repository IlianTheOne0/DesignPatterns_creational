namespace ClassLibrary.CreationalPatterns.Builder.Builder;
using ClassLibrary.CreationalPatterns.Builder.Product;

public class MaximumPackageBuilder :Builder<string, string>
{
    public MaximumPackageBuilder() => _product = new MaximumPackage();

    public override (string, string) AddFlight()
    {
        string firstResult = _GetInfo($"Add {_maximumString} {_flightString}:", _flightString);
        _product?.AddPart($"{_maximumString} {_flightString}");
        return (firstResult, $"{_maximumString} {_flightString}");
    }
    public override (string, string) AddHotel()
    {
        string firstResult = _GetInfo($"Add {_maximumString} {_hotelString}:", _hotelString);
        _product?.AddPart($"{_maximumString} {_hotelString}");
        return (firstResult, $"{_maximumString} {_hotelString}");
    }
    public override (string, string) AddTours()
    {
        string firstResult = _GetInfo($"Add {_maximumString} {_toursString}:", _toursString);
        _product?.AddPart($"{_maximumString} {_toursString}");
        return (firstResult, $"{_maximumString} {_toursString}");
    }
    public override (string, string) AddMeals()
    {
        string firstResult = _GetInfo($"Add {_maximumString} {_mealsString}:", _mealsString);
        _product?.AddPart($"{_maximumString} {_mealsString}");
        return (firstResult, $"{_maximumString} {_mealsString}");
    }
    public override (string, string) AddCarRental()
    {
        string firstResult = _GetInfo($"Add {_maximumString} {_carRentalString}:", _carRentalString);
        _product?.AddPart($"{_maximumString} {_carRentalString}");
        return (firstResult, $"{_maximumString} {_carRentalString}");
    }

    public override (string, string) RemoveFlight()
    {
        string firstResult = _GetInfo($"Remove {_maximumString} {_flightString}:", _flightString);
        _product?.RemovePart($"{_maximumString} {_flightString}");
        return (firstResult, $"{_maximumString} {_flightString}");
    }
    public override (string, string) RemoveHotel()
    {
        string firstResult = _GetInfo($"Remove {_maximumString} {_hotelString}:", _hotelString);
        _product?.RemovePart($"{_maximumString} {_hotelString}");
        return (firstResult, $"{_maximumString} {_hotelString}");
    }
    public override (string, string) RemoveTours()
    {
        string firstResult = _GetInfo($"Remove {_maximumString} {_toursString}:", _toursString);
        _product?.RemovePart($"{_maximumString} {_toursString}");
        return (firstResult, $"{_maximumString} {_toursString}");
    }
    public override (string, string) RemoveMeals()
    {
        string firstResult = _GetInfo($"Remove {_maximumString} {_mealsString}:", _mealsString);
        _product?.RemovePart($"{_maximumString} {_mealsString}");
        return (firstResult, $"{_maximumString} {_mealsString}");
    }
    public override (string, string) RemoveCarRental()
    {
        string firstResult = _GetInfo($"Remove {_maximumString} {_carRentalString}:", _carRentalString);
        _product?.RemovePart($"{_maximumString} {_carRentalString}");
        return (firstResult, $"{_maximumString} {_carRentalString}");
    }
}