using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponsManagement.Application.Interfaces;
using WeaponsManagement.Data.Repository.Interfaces;
using WeaponsManagement.Models.Equipment;

namespace WeaponsManagement.Application;

public class WeaponService : IWeaponService
{
    private readonly IGenericPersist genericPersist;
    private readonly IWeaponPersist weaponPersist;

    public WeaponService(IGenericPersist genericPersist, IWeaponPersist weaponPersist)
    {
        this.genericPersist = genericPersist;
        this.weaponPersist = weaponPersist;
    }
    public void AddWeapon(Weapon weapon)
    {
        genericPersist.Add(weapon);
        genericPersist.SaveChanges();
    }
    public void UpdateWeapon(int id, Weapon weapon)
    {
        var weaponId = weaponPersist.GetWeaponById(id);
        weaponId = weapon;
        genericPersist.UpDate(weaponId);
        genericPersist.SaveChanges();
    }

    public bool DeleteWeapon(int id)
    {
        var weaponId = weaponPersist.GetWeaponById(id);
        genericPersist.Delete(weaponId);
        return genericPersist.SaveChanges();
    }

    public List<Weapon> GetAllWeapon()
    {
        return weaponPersist.GetAllWeapons();
    }

    public Weapon GetWeaponById(int id)
    {
        return weaponPersist.GetWeaponById(id);
    }

}
