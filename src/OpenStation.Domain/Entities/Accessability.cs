namespace VacationStation.Domain.Entities;

public class Accessibility
{
    public bool WheelchairAccessible { get; set; }
    public bool AccessibleRestrooms { get; set; }
    public Parking Parking { get; set; }
}