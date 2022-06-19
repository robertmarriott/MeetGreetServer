using MeetGreetServer.Application.Common.Interfaces;
using MeetGreetServer.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace MeetGreetServer.Infrastructure.Persistence;

public class MeetGreetDbContext : DbContext, IMeetGreetDbContext
{
    public DbSet<Meeting> Meetings { get; set; } = null!;

    public MeetGreetDbContext(DbContextOptions<MeetGreetDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
