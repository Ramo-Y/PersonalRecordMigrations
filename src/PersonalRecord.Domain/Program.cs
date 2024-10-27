using Microsoft.EntityFrameworkCore;
using PersonalRecord.Domain.Models.Entities;
using PersonalRecord.Domain.Models;
using PersonalRecord.Domain;
using PersonalRecord.Domain.Exporter;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Database
var databasePath = DatabaseHelper.GetDatabasePath();
builder.Services.AddDbContext<PersonalRecordContext>(opt => opt.UseSqlite($"Data Source={databasePath}"));
builder.Services.AddTransient<PreparationDatabase>();

//Exporters
builder.Services.AddTransient<ExerciseExporter>();
builder.Services.AddTransient<WorkoutExporter>();
builder.Services.AddTransient<WorkoutToExerciseExporter>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
