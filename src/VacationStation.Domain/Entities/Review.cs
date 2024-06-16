namespace VacationStation.Domain.Entities;

public class Review
{
    public string ReviewerName { get; set; }
    public int Rating { get; set; }
    public string Comment { get; set; }
    public DateTime Date { get; set; }
}