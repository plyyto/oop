using Microsoft.EntityFrameworkCore;
using Sales.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSqlite<SalesContext>("Data Source=Sales.db");

var app = builder.Build();


app.MapGet("/", () => "Hello World!");

app.Run();