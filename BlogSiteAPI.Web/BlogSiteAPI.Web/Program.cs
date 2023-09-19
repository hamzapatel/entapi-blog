using BlogSiteAPI.Respository.Implementation;
using BlogSiteAPI.Respository.Interfaces;
using BlogSiteAPI.Respository.Models;
using BlogSiteAPI.Service.Implementation;
using BlogSiteAPI.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.ConfigureServices((hostContext, services) =>{
    services.AddScoped<IBlogService, BlogService>();
    services.AddScoped<IBlogRepository, BlogRepository>();
    services.AddSingleton<TechblogsContext, TechblogsContext>();
});
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddApiVersioning(options =>
{
    options.DefaultApiVersion = new ApiVersion(1, 0);
    options.AssumeDefaultVersionWhenUnspecified = true;
});

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