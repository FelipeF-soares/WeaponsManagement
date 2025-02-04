using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponsManagement.Data.AppDbContext;
using WeaponsManagement.Data.Repository.Interfaces;

namespace WeaponsManagement.Data.Repository;

public class GenericPersist : IGenericPersist
{
    private readonly WeaponDbContext context;

    public GenericPersist(WeaponDbContext context)
    {
        this.context = context;
    }
    public void Add<T>(T entity) where T : class
    {
        context.Add(entity);
    }

    public void Delete<T>(T entity) where T : class
    {
        context.Remove(entity);
    }

    public void UpDate<T>(T entity) where T : class
    {
        context.Update(entity);
    }
    public bool SaveChanges()
    {
        return (context.SaveChanges() > 0);
    }
}
