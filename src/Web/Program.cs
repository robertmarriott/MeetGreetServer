using Meetings.Infrastructure.Persistence;
// TODO: REMOVE using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// TODO: REMOVE builder.Services.AddDbContext<MeetingsContext>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// TODO: Do I need this?
// using (var scope = app.Services.CreateScope())
// {
//     var scopedProvider = scope.ServiceProvider;
//     var meetingsContext = scopedProvider.GetRequiredService<MeetingsContext>();
// }

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
