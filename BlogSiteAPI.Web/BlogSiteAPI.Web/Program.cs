using BlogSiteAPI.Repository.Implementation;
using BlogSiteAPI.Repository.Interfaces;
using BlogSiteAPI.Repository.Models;
using BlogSiteAPI.Service.Automapper;
using BlogSiteAPI.Service.Implementation;
using BlogSiteAPI.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);
builder.WebHost.ConfigureServices((hostContext, services) =>
{
    services.AddScoped<IBlogService, BlogService>();
    services.AddScoped<IBlogRepository, BlogRepository>();

    services.AddDbContext<TechblogsContext>(options =>
        options.UseSqlServer(hostContext.Configuration.GetConnectionString("DefaultConnection")));
    services.AddApiVersioning(options =>
    {
        options.DefaultApiVersion = new ApiVersion(1, 0);
        options.AssumeDefaultVersionWhenUnspecified = true;
    });
    services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc("v1", new OpenApiInfo { Title = "Tech Blogs API", Version = "v1" });
    });
    services.AddControllers();
    services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);
});
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Tech Blogs API v1");
    });
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();