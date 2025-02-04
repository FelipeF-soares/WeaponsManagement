using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using WeaponsManagement.Models.Equipment;
using WeaponsManagement.Models.People;
using WeaponsManagement.Models.Place;

namespace WeaponsManagement.Data.AppDbContext;

public class WeaponDbContext : DbContext
{
    public WeaponDbContext(DbContextOptions<WeaponDbContext> options) : base(options)
    {
        
    }

    public DbSet<Military> Militaries { get; set; }
    public DbSet<Weapon> Weapons { get; set; }
    public DbSet<Unit> Units { get; set; }
    public DbSet<PathPictureWeapon> PathPictureWeapons { get; set; }
    public DbSet<PathPictureMilitary> PathPictureMilitary { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Unit>().HasData
            (
                new Unit { Id = 1, Name = "Batalhão", Street="Av. Brasil", Number = "1", City="São Sebastião", Neighborhood="Paulista", State="São Paulo", UnitCode="100", ZIPCode="0800-000" }
            );
        modelBuilder.Entity<Weapon>().HasData
            (
                new Weapon { Id = 1, MaterialCode = "1000", PatrimonyNumber = "1234", SerialNumber = "AXS9878", Description = ".40", Factory = "Taurus", Value = "169,69", UnitId = 1 },
                new Weapon { Id = 2, MaterialCode = "1000", PatrimonyNumber = "4321", SerialNumber = "AXS9978", Description = ".40", Factory = "Glock", Value = "369,69", UnitId = 1 }
            );
    }

}
