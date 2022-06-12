using Meetings.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Meetings.Infrastructure.Persistence;

public class MeetingsDbContext : DbContext
{
    public DbSet<Meeting> Meetings { get; set; } = null!;

    public MeetingsDbContext(DbContextOptions<MeetingsDbContext> options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlite("Data Source=Meetings.db");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
