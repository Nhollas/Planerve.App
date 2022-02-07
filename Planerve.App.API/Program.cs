using Planerve.API.Utility;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Planerve.App.Core;
using Planerve.App.Persistence;

var builder = WebApplication.CreateBuilder(args);

// CLIENT SERVICES
builder.Services.AddApplicationServices();
builder.Services.AddPersistenceServices();

builder.Services.AddDbContext<PlanerveDbContext>(options =>
       options.UseSqlServer(builder.Configuration.GetConnectionString("PlanerveConnectionString")));

//DATA SERVICES

builder.Services.AddMvc().AddControllersAsServices();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "V1",
        Title = "Planerve API",

    });

    c.OperationFilter<FileResultContentTypeOperationFilter>();
});
builder.Services.AddCors(options =>
{
    options.AddPolicy("Open", builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();
app.MapControllers();
app.UseCors("Open");

app.Run();