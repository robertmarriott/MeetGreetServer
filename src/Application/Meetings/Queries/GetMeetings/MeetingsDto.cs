namespace Meetings.Application.Meetings.Queries.GetMeetings;

public class MeetingsDto
{
    public IList<MeetingDto> Meetings { get; set; } = new List<MeetingDto>();
}
