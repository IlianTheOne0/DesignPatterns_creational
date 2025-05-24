namespace ClassLibrary.CreationalPatterns.Builder.Builder;
using ClassLibrary.CreationalPatterns.Builder.Product;

public class NormalPackageBuilder :Builder<string, string>
{
    public NormalPackageBuilder() => _product = new NormalPackage();

    public override (string, string) AddFlight()
    {
        string firstResult = _GetInfo($"Add {_normalString} {_flightString}:", _flightString);
        _product?.AddPart($"{_normalString} {_flightString}");
        return (firstResult, $"{_normalString} {_flightString}");
    }
    public override (string, string) AddHotel()
    {
        string firstResult = _GetInfo($"Add {_normalString} {_hotelString}:", _hotelString);
        _product?.AddPart($"{_normalString} {_hotelString}");
        return (firstResult, $"{_normalString} {_hotelString}");
    }
    public override (string, string) AddTours()
    {
        string firstResult = _GetInfo($"Add {_normalString} {_toursString}:", _toursString);
        _product?.AddPart($"{_normalString} {_toursString}");
        return (firstResult, $"{_normalString} {_toursString}");
    }
    public override (string, string) AddMeals()
    {
        string firstResult = _GetInfo($"Add {_normalString} {_mealsString}:", _mealsString);
        _product?.AddPart($"{_normalString} {_mealsString}");
        return (firstResult, $"{_normalString} {_mealsString}");
    }
    public override (string, string) AddCarRental()
    {
        string firstResult = _GetInfo($"Add {_normalString} {_carRentalString}:", _carRentalString);
        _product?.AddPart($"{_normalString} {_carRentalString}");
        return (firstResult, $"{_normalString} {_carRentalString}");
    }

    public override (string, string) RemoveFlight()
    {
        string firstResult = _GetInfo($"Remove {_normalString} {_flightString}:", _flightString);
        _product?.RemovePart($"{_normalString} {_flightString}");
        return (firstResult, $"{_normalString} {_flightString}");
    }
    public override (string, string) RemoveHotel()
    {
        string firstResult = _GetInfo($"Remove {_normalString} {_hotelString}:", _hotelString);
        _product?.RemovePart($"{_normalString} {_hotelString}");
        return (firstResult, $"{_normalString} {_hotelString}");
    }
    public override (string, string) RemoveTours()
    {
        string firstResult = _GetInfo($"Remove {_normalString} {_toursString}:", _toursString);
        _product?.RemovePart($"{_normalString} {_toursString}");
        return (firstResult, $"{_normalString} {_toursString}");
    }
    public override (string, string) RemoveMeals()
    {
        string firstResult = _GetInfo($"Remove {_normalString} {_mealsString}:", _mealsString);
        _product?.RemovePart($"{_normalString} {_mealsString}");
        return (firstResult, $"{_normalString} {_mealsString}");
    }
    public override (string, string) RemoveCarRental()
    {
        string firstResult = _GetInfo($"Remove {_normalString} {_carRentalString}:", _carRentalString);
        _product?.RemovePart($"{_normalString} {_carRentalString}");
        return (firstResult, $"{_normalString} {_carRentalString}");
    }
}