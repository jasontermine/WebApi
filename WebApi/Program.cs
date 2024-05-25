using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebApi.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/persons", (AppDbContext db) =>
    {
        var persons = db.Persons.ToList();

        return persons;
    })
    .WithName("GetPersons")
    .WithOpenApi();

app.MapPost("/person", async (AppDbContext db, Person input) =>
    {
        var person = new Person
        {
            Name = input.Name,
            Age = input.Age
        };
        db.Add(person);
        await db.SaveChangesAsync();
        
        return person;
    })
    .WithName("PostPersons")
    .WithOpenApi();

app.Run();


