using System.Text.Json;


Console.WriteLine("Here is the correct json even in .NET 8, the Test controller will return incorrect json in browser window.");
//This will output the correct json in both .NET 6/7 and .NET 8
//The Test controller will return the incorrect json in .NET 8
var options = new JsonSerializerOptions();
options.Converters.Add(new ObjectJsonConverter());
Console.WriteLine(JsonSerializer.Serialize(new Test1(), options));

Console.WriteLine();


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services
    .AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.Converters.Add(new ObjectJsonConverter());
    });

var app = builder.Build();

app.UseAuthorization();

app.MapControllers();

app.Run();