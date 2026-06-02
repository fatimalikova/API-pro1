using Api_Pro1.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//later u must add resume
builder.Services.AddControllers();

// Database
var config = builder.Configuration;
builder.Services.AddDbContext<EventDbContext>(options =>
    options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//enable swagger
app.UseSwagger();
app.UseSwaggerUI();

app.UseAuthorization();

app.MapControllers();

app.Run();
