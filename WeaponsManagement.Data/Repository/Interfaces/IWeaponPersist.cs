using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponsManagement.Models.Equipment;

namespace WeaponsManagement.Data.Repository.Interfaces;

public interface IWeaponPersist 
{
    List<Weapon> GetAllWeapons();
    Weapon? GetWeaponById(int id);
}
