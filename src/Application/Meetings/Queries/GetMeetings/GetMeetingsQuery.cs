using MediatR;

namespace MeetGreetServer.Application.MeetGreetServer.Queries.GetMeetings;

public record GetMeetingsQuery : IRequest<MeetingsDto>;
