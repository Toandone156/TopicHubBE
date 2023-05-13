using Microsoft.EntityFrameworkCore;
using TopicHubBE.Data;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

//Add Database Context
services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("MSSQL"));
    options.UseLoggerFactory(LoggerFactory.Create(builder =>
    {
        builder
        .AddFilter(DbLoggerCategory.Query.Name, LogLevel.Information)
        .AddConsole();
    }));
});

// Add services to the container.
services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
services.AddEndpointsApiExplorer();
services.AddSwaggerGen();

var app = builder.Build();

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
