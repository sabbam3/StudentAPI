using Microsoft.EntityFrameworkCore;
using StudentAPI.Db;
using StudentAPI.Features.AddStudent;
using StudentAPI.Abstraction.IStudent;
using StudentAPI.Abstraction.ISubject;
using StudentAPI.Features.AddSubject;
using StudentAPI.Abstraction.IGrade;
using StudentAPI.Features.GPACalculator;
using StudentAPI;
using StudentAPI.Abstraction.IGPA;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(c => c.UseSqlServer(builder.Configuration["AppDbContextConnection"]), ServiceLifetime.Scoped);
builder.Services.AddScoped<IAddStudentRepository, StudentAPI.Features.AddStudent.AddRepository>();
builder.Services.AddTransient<IAddStudentService, StudentAPI.Features.AddStudent.AddService>();
builder.Services.AddScoped<IAddSubjectRepository, StudentAPI.Features.AddSubject.AddRepository>();
builder.Services.AddTransient<IAddSubjectService, StudentAPI.Features.AddSubject.AddService>();
builder.Services.AddScoped<IAddStudentGradeRepository, StudentAPI.Features.AddGrade.AddRepository>();
builder.Services.AddTransient<IAddStudentGradeService, StudentAPI.Features.AddGrade.AddService>();
builder.Services.AddScoped<IGetGradesRepository, StudentAPI.Features.GetGrades.GetRepository>();
builder.Services.AddTransient<IGetGradesService, StudentAPI.Features.GetGrades.GetService>();
builder.Services.AddScoped<IGPARepository, GPARepository>();
builder.Services.AddTransient<IGPAService, GPAService>();
builder.Services.AddTransient<Validations>();


//builder.Services.AddTransient<ValidateRequests>();
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
