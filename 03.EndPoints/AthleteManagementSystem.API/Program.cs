using AthleteManagementSystem.ApplicationService.Athletes;
using AthleteManagementSystem.Domain.Athletes.Contracts;
using AthleteManagementSystem.Framework.Domain.Data;
using AthleteManagementSystem.SqlServer;
using AthleteManagementSystem.SqlServer.Athletes;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<EFDataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("dbConnectionString"));
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<UnitOfWork,EFUnitOfWork>();
builder.Services.AddScoped<AthleteRepository,EFAthleteRepository>();
builder.Services.AddScoped<AddAthleteHandler>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
