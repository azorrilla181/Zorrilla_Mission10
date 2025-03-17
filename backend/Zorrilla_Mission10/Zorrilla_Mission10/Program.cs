using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Zorrilla_Mission10.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<BowlerDBContext>(options =>
{
    options.UseSqlite(builder.Configuration["ConnectionStrings:BowlingConnection"]);
});

//ConfigureAwaitOptions CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend",
        builder =>
        {
            builder.WithOrigins("http://localhost:3000/", "http://localhost:3001/")
                    .AllowAnyMethod()
                    .AllowAnyHeader();
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseCors("AllowFrontEnd");

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
