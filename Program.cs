// 1.using para trabajar con EntityFramework

using Microsoft.EntityFrameworkCore;
using FirstBackEnd.DataAccess;

var builder = WebApplication.CreateBuilder(args);

//2. Connection with SQL EXPRESS

const string CONNECTIONNAME= "UniversityDB";
var connectionStrings = builder.Configuration.GetConnectionString(CONNECTIONNAME);

//3. Add context

builder.Services.AddDbContext<UniversityContext>(options => options.UseSqlServer(connectionStrings));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
