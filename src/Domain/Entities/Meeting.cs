namespace Meetings.Domain.Entities;

public class Meeting
{
    public Guid Id { get; set; }
    public string Category { get; set; } = null!;
    public string Title { get; set; } = null!;
    public string? Description { get; set; }
    public string City { get; set; } = null!;
    public string Venue { get; set; } = null!;
    public DateTime Date { get; set; }
}
