using Microsoft.EntityFrameworkCore;
using CustomerApi.Data;
using CustomerApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<CustomerApiContext>(opt => opt.UseInMemoryDatabase("CustomersDb"));

// Register repositories for dependency injection
builder.Services.AddScoped<IRepository<Customer>, CustomerRepository>();

// Register database initializer for dependency injection
builder.Services.AddTransient<IDbInitializer, DbInitializer>();

builder.Services.AddControllers();
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

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
