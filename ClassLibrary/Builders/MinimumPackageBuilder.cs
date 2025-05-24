namespace ClassLibrary.CreationalPatterns.Builder.Builder;
using ClassLibrary.CreationalPatterns.Builder.Product;

public class MinimumPackageBuilder :Builder<string, string>
{
    public MinimumPackageBuilder() => _product = new MinimumPackage();

    public override (string, string) AddFlight()
    {
        string firstResult = _GetInfo($"Add {_minimumString} {_flightString}:", _flightString);
        _product?.AddPart($"{_minimumString} {_flightString}");
        return (firstResult, $"{_minimumString} {_flightString}");
    }
    public override (string, string) AddHotel()
    {
        string firstResult = _GetInfo($"Add {_minimumString} {_hotelString}:", _hotelString);
        _product?.AddPart($"{_minimumString} {_hotelString}");
        return (firstResult, $"{_minimumString} {_hotelString}");
    }
    public override (string, string) AddTours()
    {
        string firstResult = _GetInfo($"Add {_minimumString} {_toursString}:", _toursString);
        _product?.AddPart($"{_minimumString} {_toursString}");
        return (firstResult, $"{_minimumString} {_toursString}");
    }
    public override (string, string) AddMeals()
    {
        string firstResult = _GetInfo($"Add {_minimumString} {_mealsString}:", _mealsString);
        _product?.AddPart($"{_minimumString} {_mealsString}");
        return (firstResult, $"{_minimumString} {_mealsString}");
    }
    public override (string, string) AddCarRental()
    {
        string firstResult = _GetInfo($"Add {_minimumString} {_carRentalString}:", _carRentalString);
        _product?.AddPart($"{_minimumString} {_carRentalString}");
        return (firstResult, $"{_minimumString} {_carRentalString}");
    }

    public override (string, string) RemoveFlight()
    {
        string firstResult = _GetInfo($"Remove {_minimumString} {_flightString}:", _flightString);
        _product?.RemovePart($"{_minimumString} {_flightString}");
        return (firstResult, $"{_minimumString} {_flightString}");
    }
    public override (string, string) RemoveHotel()
    {
        string firstResult = _GetInfo($"Remove {_minimumString} {_hotelString}:", _hotelString);
        _product?.RemovePart($"{_minimumString} {_hotelString}");
        return (firstResult, $"{_minimumString} {_hotelString}");
    }
    public override (string, string) RemoveTours()
    {
        string firstResult = _GetInfo($"Remove {_minimumString} {_toursString}:", _toursString);
        _product?.RemovePart($"{_minimumString} {_toursString}");
        return (firstResult, $"{_minimumString} {_toursString}");
    }
    public override (string, string) RemoveMeals()
    {
        string firstResult = _GetInfo($"Remove {_minimumString} {_mealsString}:", _mealsString);
        _product?.RemovePart($"{_minimumString} {_mealsString}");
        return (firstResult, $"{_minimumString} {_mealsString}");
    }
    public override (string, string) RemoveCarRental()
    {
        string firstResult = _GetInfo($"Remove {_minimumString} {_carRentalString}:", _carRentalString);
        _product?.RemovePart($"{_minimumString} {_carRentalString}");
        return (firstResult, $"{_minimumString} {_carRentalString}");
    }
}