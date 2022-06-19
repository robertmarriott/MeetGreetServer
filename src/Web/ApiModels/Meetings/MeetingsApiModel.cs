namespace MeetGreetServer.Web.ApiModels.Meetings;

public class MeetingsApiModel
{
    public IList<MeetingApiModel> Meetings { get; set; } = new List<MeetingApiModel>();
}
