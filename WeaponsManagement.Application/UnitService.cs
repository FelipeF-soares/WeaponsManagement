using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponsManagement.Application.Interfaces;
using WeaponsManagement.Data.Repository.Interfaces;
using WeaponsManagement.Models.Place;

namespace WeaponsManagement.Application;

public class UnitService : IUnitService
{
    private readonly IGenericPersist genericPersist;
    private readonly IUnitPersist unitPersist;

    public UnitService(IGenericPersist genericPersist, IUnitPersist unitPersist)
    {
        this.genericPersist = genericPersist;
        this.unitPersist = unitPersist;
    }
    void IUnitService.AddUnit(Unit unit)
    {
        genericPersist.Add(unit);
        genericPersist.SaveChanges();
    }

    void IUnitService.UpdateUnit(int id, Unit unit)
    {
        var unitId = unitPersist.GetUnitById(id);
        unitId = unit;
        genericPersist.UpDate(unitId);
        genericPersist.SaveChanges();
    }

    bool IUnitService.DeleteUnit(int id)
    {
        var unitId = unitPersist.GetUnitById(id);
        genericPersist.Delete(unitId);
        return genericPersist.SaveChanges();
    }

    List<Unit> IUnitService.GetAllUnits()
    {
        return unitPersist.GetAll();
    }

    Unit IUnitService.GetUnit(int id)
    {
        return unitPersist.GetUnitById(id);
    }
}
