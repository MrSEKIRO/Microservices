using Podcasts.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.MapGet("/podcasts", async context =>
{
	var podcasts = new List<Podacast>()
	{
		new Podacast()
		{
			Id = 1,
			Name = "Podcast1",
			CreateDate = DateTime.Now,
			Description = "Some desc",
		},
		new Podacast()
		{
			Id = 2,
			Name = "El Che",
			CreateDate= DateTime.Now.AddDays(-1),
			Description = null,
		},
	};

	await context.Response.WriteAsJsonAsync(podcasts);
});

app.Run();