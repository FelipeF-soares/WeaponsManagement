using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponsManagement.Models.Equipment;

namespace WeaponsManagement.Application.Interfaces;

public interface IWeaponService
{
    void AddWeapon (Weapon weapon);
    void UpdateWeapon (int id, Weapon weapon);
    bool DeleteWeapon (int id);
    List<Weapon> GetAllWeapon ();
    Weapon GetWeaponById (int id);
}
