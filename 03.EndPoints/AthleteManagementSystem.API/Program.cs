using AthleteManagementSystem.ApplicationService.Athletes;
using AthleteManagementSystem.Domain.Athletes.Contracts;
using AthleteManagementSystem.Framework.Domain.Data;
using AthleteManagementSystem.SqlServer;
using AthleteManagementSystem.SqlServer.Athletes;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<EFDataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("dbConnectionString"));
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<UnitOfWork, EFUnitOfWork>();
builder.Services.AddScoped<AthleteRepository, EFAthleteRepository>();
builder.Services.AddScoped<AthleteQueryRepository, DapperAthleteQueryRepository>();
builder.Services.AddScoped<AddAthleteHandler>();
builder.Services.AddScoped(c => 
    new SqlConnection(builder.Configuration.GetConnectionString("dbConnectionString")));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseDeveloperExceptionPage();
app.UseAuthorization();

app.MapControllers();

app.Run();
