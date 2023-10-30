using MongoDB.Driver;
using Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddCors();
//builder.Services.AddServices();



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




