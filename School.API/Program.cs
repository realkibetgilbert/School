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
using Microsoft.AspNetCore.Identity;
using School.MODEL;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

var logPath = builder.Configuration.GetValue<string>("LogPath");
Log.Logger = new LoggerConfiguration()
    .WriteTo.File(
        path: logPath ?? "C:\\Logs",  // Default fallback path if LogPath is missing
        outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}",
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
builder.Services.AddIdentityCore<AuthUser>()
    .AddRoles<IdentityRole<long>>()
    .AddTokenProvider<DataProtectorTokenProvider<AuthUser>>("School")
    .AddEntityFrameworkStores<SchoolDbContext>()
    .AddDefaultTokenProviders();
builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 4;
    options.Password.RequiredUniqueChars = 1;
}
);
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration["Jwt:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
    });
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
