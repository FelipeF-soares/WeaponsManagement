using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponsManagement.Models.Equipment;

public class PathPictureWeapon
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Path { get; set; }
    public int WeaponId { get; set; }
}
