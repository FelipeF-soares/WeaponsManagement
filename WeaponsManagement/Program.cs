using Microsoft.EntityFrameworkCore;
using WeaponsManagement.Application;
using WeaponsManagement.Application.Interfaces;
using WeaponsManagement.Data.AppDbContext;
using WeaponsManagement.Data.Repository;
using WeaponsManagement.Data.Repository.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

string stringConnection = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContext<WeaponDbContext>
    (
        option => option.UseMySql(stringConnection,ServerVersion.AutoDetect(stringConnection))
    );
builder.Services.AddScoped<IMilitaryPersist, MilitaryPersist>();
builder.Services.AddScoped<IUnitPersist, UnitPersist>();
builder.Services.AddScoped<IWeaponPersist, WeaponPersist>();
builder.Services.AddScoped<IGenericPersist, GenericPersist>();

builder.Services.AddScoped<IMilitaryService, MilitaryService>();
builder.Services.AddScoped<IUnitService, UnitService>();
builder.Services.AddScoped<IWeaponService, WeaponService>();



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
    pattern: "{area=User}/{controller=Home}/{action=Index}/{id?}");

app.Run();
