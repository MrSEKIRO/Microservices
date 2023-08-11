using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

// Add services to the container.
builder.Services.AddOcelot();

builder.Configuration.SetBasePath(builder.Environment.ContentRootPath)
					 .AddJsonFile("ocelot.json")
					 .AddEnvironmentVariables();



var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();



app.UseRouting();
app.UseOcelot();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();