using Microsoft.EntityFrameworkCore;
using DotNetEnv;
using backend_test_dotnet_API.Controllers;
using backend_test_dotnet_API.Data;

var builder = WebApplication.CreateBuilder(args);

// database
Env.Load();
string? DBConection = Environment.GetEnvironmentVariable("StringConection");

builder.Services.AddDbContextPool<AppDbContext>(options =>
    options.UseMySql(DBConection,
    ServerVersion.AutoDetect(DBConection
)));

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.MapOpenApi();
}

app.UseHttpsRedirection();

// rotas
app.AddEstablishmentRouter();
app.AddVehiclesRouter();


app.Run();
