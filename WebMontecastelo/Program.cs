using Microsoft.EntityFrameworkCore;
using WebMontecastelo.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<MontecasteloContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("ConexionTarea3")));

builder.Services.AddControllersWithViews();

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

app.MapControllerRoute(
    name: "MiCurriculum",
    pattern: "{controller=MiCurriculum}/{action=MiCurriculum}");

app.MapControllerRoute(
    name: "Asignaturas",
    pattern: "{controller=Asignaturas}/{action=Lista}");

app.MapControllerRoute(
    name: "Estudiantes",
    pattern: "{controller=Estudiantes}/{action=Lista}");

app.MapControllerRoute(
    name: "Profesores",
    pattern: "{controller=Profesores}/{action=Lista}");

app.Run();