using System;
using System.ComponentModel.Design;
using System.Net.NetworkInformation;
using RestWithASPNETUdemy.Model.Context;
using RestWithASPNETUdemy.Repository.Implementations;
using RestWithASPNETUdemy.Business.Implementations;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddControllers();

var connection = builder.Configuration["SqliteConnection:SqliteConnectionString"];
builder.Services.AddDbContext<SQLiteContext>(options => options.UseSqlite(connection));


//Versioning API
builder.Services.AddApiVersioning();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IPersonRepository, PersonRepositoryImplementation>();
builder.Services.AddScoped<IPersonBusiness, PersonBusinessImplementation>();
builder.Services.AddScoped<IBookRepository, BookRepositoryImplementation>();
builder.Services.AddScoped<IBookBusiness, BookBusinessImplementation>();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


