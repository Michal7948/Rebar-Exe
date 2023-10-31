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

builder.Services.AddScoped<IShakeRepository, ShakeRepository>();
builder.Services.AddScoped<IShakeService, ShakeService>();

builder.Services.AddControllers();
//builder.Services.AddCors();
//builder.Services.AddServices();

builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

var app = builder.Build();


app.UseCors(options =>
{
    options.WithOrigins("http://localhost:4200").AllowAnyHeader().AllowAnyMethod();
});



app.MapControllers();



app.MapGet("/", () => "Hello World!");

app.Run();





//string connectionString = "mongodb://127.0.0.1:27017";
//string databaseName = "reber_db";
//string collectionName = "shakes";

//var client = new MongoClient(connectionString);
//var db = client.GetDatabase(databaseName);
//var collection = db.GetCollection<Shake>(collectionName);

//var shake = new ShakeModel { Name = "chocolate" };

//await collection.InsertOneAsync(shake);

//var results = await collection.FindAsync(_ => true);
//foreach (var result in results.ToList())
//{
//    Console.WriteLine($"{result.Id} : {result.Name}");
//}




