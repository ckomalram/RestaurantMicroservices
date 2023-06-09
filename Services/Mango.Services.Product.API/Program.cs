using AutoMapper;
using Mango.Services.Product.API.Core.Context;
using Mango.Services.Product.API.Core.Models.Dtos;
using Mango.Services.Product.API.Core.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//conf cors
builder.Services.AddCors(opt =>
{
    opt.AddPolicy("CorsRule", rule =>
    {
        // rule.AllowAnyHeader().AllowAnyMethod().WithOrigins("https://mipagina.com");
        rule.AllowAnyHeader().AllowAnyMethod().WithOrigins("*");
    });
});

// conf automapper
builder.Services.AddAutoMapper(typeof(MappingProfile));
//Conf ef
builder.Services.AddSqlServer<ApplicationDbContext>(builder.Configuration.GetConnectionString("cnMangoProduct"));

// conf repo's
builder.Services.AddScoped<IProductRepository, ProductRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("CorsRule");

app.UseAuthorization();

app.MapControllers();

app.Run();
