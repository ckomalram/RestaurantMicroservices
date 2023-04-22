using AutoMapper;
using Mango.Services.Product.API.Core.Context;
using Mango.Services.Product.API.Core.Models.Dtos;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// conf automapper
builder.Services.AddAutoMapper(typeof(MappingProfile));
//Conf ef
builder.Services.AddSqlServer<ApplicationDbContext>(builder.Configuration.GetConnectionString("cnMangoProduct"));


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

app.Run();
