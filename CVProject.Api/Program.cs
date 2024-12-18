using CVProject.Core.Helper;
using CVProject.Core.Interfaces.Repository;
using CVProject.Infrastructure.Data;
using CVProject.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Set up Serilog to read from configuration
builder.Host.UseSerilog((context, configuration) => configuration.ReadFrom.Configuration(context.Configuration));


builder.Services.AddCors(option => option.AddPolicy("MyPolicy", p => p.WithOrigins("http://localhost:4200", "https://suphibayrak.com").AllowAnyHeader().AllowAnyMethod().AllowCredentials()));

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IPersonRepository, PersonRepository>();
builder.Services.AddScoped<IPersonExperienceRepository, PersonExperienceRepository>();
builder.Services.AddScoped<IPersonEducationRepository, PersonEducationRepository>();
builder.Services.AddScoped<IPersonProjectRepository, PersonProjectRepository>();
builder.Services.AddScoped<IPersonSkillRepository, PersonSkillRepository>();
builder.Services.AddScoped<IPersonLanguageRepository, PersonLanguageRepository>();

//Mapper
builder.Services.AddAutoMapper(typeof(ApiMappingProfile));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



var app = builder.Build();

app.UseSerilogRequestLogging();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("MyPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
