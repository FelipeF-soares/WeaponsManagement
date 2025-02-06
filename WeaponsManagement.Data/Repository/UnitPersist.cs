using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponsManagement.Data.AppDbContext;
using WeaponsManagement.Data.Repository.Interfaces;
using WeaponsManagement.Models.Place;

namespace WeaponsManagement.Data.Repository;

public class UnitPersist : IUnitPersist
{
    private readonly WeaponDbContext context;

    public UnitPersist(WeaponDbContext context)
    {
        this.context = context;
    }
    public Unit? GetUnitById(int id)
    {
        IQueryable<Unit> query = context.Units.Include(weapons => weapons.Weapons).AsNoTracking();
        return query.FirstOrDefault(unit => unit.Id == id);
    }
    public List<Unit> GetAll()
    {
        return context.Units.Include(weapons => weapons.Weapons).AsNoTracking().ToList();
    }
}
