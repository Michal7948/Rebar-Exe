using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Repositories;
using Repositories.Models;
using Services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.Configure<RebarDatabaseSettings>(
                 builder.Configuration.GetSection(nameof(RebarDatabaseSettings)));
builder.Services.AddSingleton<IRebarDatabaseSettings>(sp =>
    sp.GetRequiredService<IOptions<RebarDatabaseSettings>>().Value);
builder.Services.AddSingleton<IMongoClient>(s =>
    new MongoClient(builder.Configuration.GetValue<string>("RebarDatabaseSettings:ConnectionString")));

//builder.Services.AddScoped<IShakeRepository, ShakeRepository>();
//builder.Services.AddScoped<IShakeService, ShakeService>();

builder.Services.AddControllers();
//builder.Services.AddCors();
builder.Services.AddServices();

builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();


app.UseCors(options =>
{
    options.WithOrigins("http://localhost:4200").AllowAnyHeader().AllowAnyMethod();
});


app.MapControllers();


app.MapGet("/", () => "Hello World!");

app.Run();





