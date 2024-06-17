namespace VacationStation.Domain.Entities;

public class FuelInfo
{
    public List<string> FuelTypesAvailable { get; set; }
    public Dictionary<string, double> FuelPrices { get; set; }
}