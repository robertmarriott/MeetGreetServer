using MediatR;

namespace Meetings.Application.Meetings.Queries.GetMeetings;

public record GetMeetingsQuery : IRequest<MeetingsDto>;

public class GetMeetingsQueryHandler : IRequestHandler<GetMeetingsQuery, MeetingsDto>
{
    public GetMeetingsQueryHandler(MeetingsContext context)
    {
    }

    public async Task<MeetingsDto> Handle(GetMeetingsQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
