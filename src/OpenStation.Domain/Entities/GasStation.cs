using System.ComponentModel.DataAnnotations;

namespace VacationStation.Domain.Entities;

public class GasStation
{
    
    [Key]
    public string Id { get; set; }
    public string Name { get; set; }
    public string Brand { get; set; }

    public Location Location { get; set; }
    public ContactInfo ContactInfo { get; set; }
    public OperationalDetails OperationalDetails { get; set; }
    public FuelInfo FuelInfo { get; set; }
    public Amenities Amenities { get; set; }
    public Services Services { get; set; }
    public Accessibility Accessibility { get; set; }
    public SafetyAndSecurity SafetyAndSecurity { get; set; }
    public AdditionalFeatures AdditionalFeatures { get; set; }
    public ReviewsAndRatings ReviewsAndRatings { get; set; }
    public Media Media { get; set; }
}