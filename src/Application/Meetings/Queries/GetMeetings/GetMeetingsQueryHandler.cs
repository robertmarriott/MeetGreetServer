using MediatR;
using MeetGreetServer.Application.Common.Interfaces;
using MeetGreetServer.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MeetGreetServer.Application.MeetGreetServer.Queries.GetMeetings;

public class GetMeetingsQueryHandler : IRequestHandler<GetMeetingsQuery, List<Meeting>>
{
    private readonly IMeetGreetDbContext _context;

    public GetMeetingsQueryHandler(IMeetGreetDbContext context)
    {
        _context = context;
    }

    public async Task<List<Meeting>> Handle(GetMeetingsQuery request, CancellationToken cancellationToken)
    {
        return await _context.Meetings
            .AsNoTracking()
            .ToListAsync();
    }
}
