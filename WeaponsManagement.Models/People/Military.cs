using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponsManagement.Models.People;

public class Military
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string RE { get; set; }
    public int WeaponId { get; set; }
    public virtual PathPictureMilitary PathPicture {  get; set; }
}
