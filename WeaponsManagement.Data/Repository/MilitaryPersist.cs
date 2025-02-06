using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponsManagement.Data.AppDbContext;
using WeaponsManagement.Data.Repository.Interfaces;
using WeaponsManagement.Models.People;

namespace WeaponsManagement.Data.Repository;

public class MilitaryPersist : IMilitaryPersist
{
    private readonly WeaponDbContext context;

    public MilitaryPersist(WeaponDbContext context)
    {
        this.context = context;
    }
    public List<Military> GetAllMilitaries()
    {
       return context.Militaries.Include(picture => picture.PathPicture)
                                .AsNoTracking()
                                .ToList();
    }

    public Military? GetMilitaryById(int id)
    {
        IQueryable<Military> query = context.Militaries.Include(picture =>picture.PathPicture).AsNoTracking();
        return query.FirstOrDefault(military => military.Id == id);
    }
}
