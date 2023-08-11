using Auth.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();


app.MapGet("/users", async context =>
{
	var users = new List<User>
	{
		new User()
		{
			Id = 1,
			Name = "John",
			Age = 12,
		},
		new User()
		{
			Id =2,
			Name = "Jane",
			Age = 15,
		}
	};

	await context.Response.WriteAsJsonAsync(users);
});


app.Run();
