using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponsManagement.Data.AppDbContext;
using WeaponsManagement.Data.Repository.Interfaces;
using WeaponsManagement.Models.Equipment;

namespace WeaponsManagement.Data.Repository;

public class WeaponPersist : IWeaponPersist
{
    private readonly WeaponDbContext context;

    public WeaponPersist(WeaponDbContext context)
    {
        this.context = context;
    }
    public List<Weapon> GetAllWeapons()
    {
        List<Weapon> query = context.Weapons.Include(w => w.Military).AsNoTracking().ToList();
        return query.ToList();
    }

    public Weapon GetWeaponById(int id)
    {
        IQueryable<Weapon> query = context.Weapons.Include(w => w.Military).AsNoTracking();
        return query.FirstOrDefault(weapon => weapon.Id == id);
    }
}
