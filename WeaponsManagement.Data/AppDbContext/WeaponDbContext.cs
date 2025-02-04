using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

}
