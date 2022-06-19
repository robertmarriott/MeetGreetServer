namespace MeetGreetServer.Application.MeetGreetServer.Queries.GetMeetings;

public class MeetingsDto
{
    public IList<MeetingDto> MeetGreetServer { get; set; } = new List<MeetingDto>();
}
