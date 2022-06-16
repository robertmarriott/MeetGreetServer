using Meetings.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Meetings.Application.Common.Interfaces;

public interface IMeetingsContext
{
    DbSet<Meeting> Meetings { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
