using Microsoft.EntityFrameworkCore;
using Minimal_API;
using Minimal_API.Models;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApiContext>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ISearchCriteriaService, SearchCriteriaService>();

//<<============================================================>>

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.MapGet("/criterias", async (ISearchCriteriaService searchCriteriaService) 
    => await searchCriteriaService.GetSearchCriterias());

app.Run();
