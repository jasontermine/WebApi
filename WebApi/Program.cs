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

app.MapGet("/employees", (AppDbContext db) =>
    {
        var employees = db.Employees.ToList();

        return employees;
    })
    .WithName("GetEmployees")
    .WithOpenApi();

app.MapPost("/employee", async (AppDbContext db, Employee input) =>
    {
        var employee = new Employee
        {
            FirstName = input.FirstName,
            LastName = input.LastName,
            Age = input.Age
        };
        db.Add(employee);
        await db.SaveChangesAsync();
        
        return employee;
    })
    .WithName("PostEmployees")
    .WithOpenApi();

app.Run();


