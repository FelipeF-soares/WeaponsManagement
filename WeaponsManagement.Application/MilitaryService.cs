using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponsManagement.Application.Interfaces;
using WeaponsManagement.Data.Repository.Interfaces;
using WeaponsManagement.Models.People;

namespace WeaponsManagement.Application;

public class MilitaryService : IMilitaryService
{
    private readonly IGenericPersist genericPersist;
    private readonly IMilitaryPersist militaryPersist;

    public MilitaryService(IGenericPersist genericPersist, IMilitaryPersist militaryPersist)
    {
        this.genericPersist = genericPersist;
        this.militaryPersist = militaryPersist;
    }
    void IMilitaryService.AddMilitary(Military military)
    {
        genericPersist.Add(military);
        genericPersist.SaveChanges();
    }

    bool IMilitaryService.DeleteMilitary(int id)
    {
        var militaryId = militaryPersist.GetMilitaryById(id);
        genericPersist.Delete(militaryId);
        return genericPersist.SaveChanges();
    }
    void IMilitaryService.UpdateMilitary(int id, Military military)
    {
        var militayId = militaryPersist.GetMilitaryById(id);
        militayId = military;
    }

    List<Military> IMilitaryService.GetAllMilitary()
    {
        return militaryPersist.GetAllMilitaries();
    }

    Military IMilitaryService.GetMilitaryById(int id)
    {
        return militaryPersist.GetMilitaryById(id);
    }

    
}
