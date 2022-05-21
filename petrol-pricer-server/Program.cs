using Microsoft.EntityFrameworkCore;
using petrol_pricer_server.Database;
using petrol_pricer_server.Services;

var builder = WebApplication.CreateBuilder(args);

// Get connection strings to database. Needed to create database context.
string connectionStrings = builder.Configuration.GetConnectionString("Database");

/* 
 * Add services to the container. 
 */

builder.Services.AddControllers();

// Create database contex.
builder.Services.AddDbContext<DatabaseContext>(options => options.UseNpgsql(connectionStrings));

// Add services as singletons to make it possible to inject them as dependency.
builder.Services.AddTransient<IStationService, StationService>();
builder.Services.AddTransient<IPricesService, PricesService>();
builder.Services.AddTransient<ICoordsService, CoordsService>();

var app = builder.Build();

/* 
 * Configure the HTTP request pipeline. 
 */

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
