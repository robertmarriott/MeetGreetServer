using Meetings.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Meetings.Infrastructure.Persistence;

public class MeetingsContext : DbContext
{
    public DbSet<Meeting> Meetings { get; set; } = null!;

    public MeetingsContext(DbContextOptions<MeetingsContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
