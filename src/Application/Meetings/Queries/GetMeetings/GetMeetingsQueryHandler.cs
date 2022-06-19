using MediatR;
using MeetGreetServer.Application.Common.Interfaces;

namespace MeetGreetServer.Application.MeetGreetServer.Queries.GetMeetings;

public class GetMeetingsQueryHandler : IRequestHandler<GetMeetingsQuery, MeetingsDto>
{
    private readonly IMeetGreetDbContext _context;

    public GetMeetingsQueryHandler(IMeetGreetDbContext context)
    {
        _context = context;
    }

    public async Task<MeetingsDto> Handle(GetMeetingsQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
