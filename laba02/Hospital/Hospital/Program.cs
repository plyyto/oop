using Microsoft.EntityFrameworkCore;
using Hospital.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSqlite<HospitalContext>("Data Source=Hospital.db");

var app = builder.Build();


app.MapGet("/", () => "Hello World!");

app.Run();