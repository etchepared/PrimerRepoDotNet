using Microsoft.EntityFrameworkCore;
using PrimerRepoDotNet.DataAccess;
using PrimerRepoDotNet.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ContextDB>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")); //trae del appsetting.json la DefaultConnection
});
builder.Services.AddScoped<IUnitOfWork, UnitOfWorkService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
