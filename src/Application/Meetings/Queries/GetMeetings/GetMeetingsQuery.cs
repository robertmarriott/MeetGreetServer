using MediatR;
using MeetGreetServer.Domain.Entities;

namespace MeetGreetServer.Application.MeetGreetServer.Queries.GetMeetings;

public record GetMeetingsQuery : IRequest<List<Meeting>>;
