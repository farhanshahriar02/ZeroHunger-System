using BLL;
using DAL.EF;
using BLL.Service;
using DAL.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// OpenAPI
builder.Services.AddOpenApi();


// Database
builder.Services.AddDbContext<ZeroHungerDbContext>(opt =>
{
    opt.UseSqlServer(
        builder.Configuration.GetConnectionString("DbConn")
    );
});


// Repository
builder.Services.AddScoped<RestaurantRepository>();
builder.Services.AddScoped<EmployeeRepository>();
builder.Services.AddScoped<CollectRequestRepository>();
builder.Services.AddScoped<DistributionRepository>();

builder.Services.AddAutoMapper(typeof(MappingProfile));


// Services

builder.Services.AddScoped<RestaurantService>();
builder.Services.AddScoped<EmployeeService>();
builder.Services.AddScoped<CollectRequestService>();
builder.Services.AddScoped<DistributionService>();



var app = builder.Build();


// Configure the HTTP request pipeline.

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();