using FluentValidation;
using Microsoft.EntityFrameworkCore;
using School.API.Data;
using School.API.Interfaces.implementations;
using School.API.Interfaces.studentsImplementations;
using School.API.Interfaces.unitsImplementations;
using School.API.Utils;
using School.API.Utils.Validators;
using Serilog.Events;
using Serilog;
using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);
Log.Logger = new LoggerConfiguration()
               .WriteTo.File(
               path: builder.Configuration.GetValue<string>("LogPath"),
               outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm,ss.fff zzz}[{Level:u3}] {Message:lj}{NewLine}{Exception}",
               rollingInterval: RollingInterval.Day,
               restrictedToMinimumLevel: LogEventLevel.Information
               ).CreateLogger();
builder.Host.UseSerilog();

// Add services to the container.
builder.Services.AddDbContext<SchoolDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("SchoolConnectionString")
));
builder.Services.AddControllers();
builder.Services.AddValidatorsFromAssemblyContaining<UnitDtoValidator>();



//register services
builder.Services.AddScoped<IHostelService, HostelService>();
builder.Services.AddScoped<IStudentService, StudentService>();
builder.Services.AddScoped<IUnitService, UnitService>();

builder.Services.AddAutoMapper(typeof(MappingProfile));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsProduction())
{
}
    app.UseSwagger();
    app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseCors(options =>
{
    options.AllowAnyHeader();
    options.AllowAnyMethod();
    options.AllowAnyOrigin();
    //options.WithOrigins("http://localhost:4200/");
});
app.MapControllers();

app.Run();
