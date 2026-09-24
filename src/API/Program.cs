using API.Helpers;
using Application;
using Infrastructure;
using DotNetEnv;

var builder = WebApplication.CreateBuilder(args);

Env.Load("../../");
builder.Configuration.AddEnvironmentVariables();

builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddApplication();

builder.Services.AddSwagger();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
