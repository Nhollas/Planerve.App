﻿using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Planerve.App.API.Services;
using Planerve.App.Core;
using Planerve.App.Core.Contracts.Identity;
using Planerve.App.Core.Contracts.Persistence;
using Planerve.App.Identity;
using Planerve.App.Persistence;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;

// CLIENT SERVICES
builder.Services.AddApplicationServices();
builder.Services.AddPersistenceServices();
builder.Services.AddIdentityServices();

builder.Services.AddDbContext<PlanerveDbContext>(options =>
       options.UseSqlServer(builder.Configuration.GetConnectionString("PlanerveConnectionString")));

builder.Services.AddScoped<ILoggedInUserService, LoggedInUserService>();
builder.Services.AddScoped<IPostcodeService, PostcodeService>();


builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
})
    .AddJwtBearer("Bearer", options =>
    {
        options.Authority = "https://localhost:7001";
        options.TokenValidationParameters.ValidateAudience = false;
    });

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("ApiScope", policy =>
    {
        policy.RequireAuthenticatedUser();
        policy.RequireClaim("scope", "planerveappapi");
    });
});
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "PlanerveApp API", Version = "v1" });

    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
    {
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "JWT Authorization header using the Bearer scheme."

    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
                new OpenApiSecurityScheme
                {
                    Reference = new OpenApiReference
                    {
                        Type = ReferenceType.SecurityScheme,
                        Id = "Bearer"
                    }
                },
                new string[] {}
        }
    });
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

app.UseAuthentication();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllers();
app.UseCors("Open");

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers().RequireAuthorization("ApiScope");
});

app.Run();