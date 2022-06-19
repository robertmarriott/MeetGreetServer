using MeetGreetServer.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MeetGreetServer.Application.Common.Interfaces;

public interface IMeetGreetDbContext
{
    DbSet<Meeting> Meetings { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
