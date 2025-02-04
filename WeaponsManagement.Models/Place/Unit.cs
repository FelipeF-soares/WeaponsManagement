using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponsManagement.Models.Equipment;

namespace WeaponsManagement.Models.Place;

public class Unit : Address
{
    [Key]
    public int Id { get; set; }
    [Required]
    [DisplayName("Código da Unidade")]
    public string UnitCode { get; set; }
    [Required]
    [DisplayName("Nome da Unidade")]
    public string Name { get; set; }
    public virtual ICollection<Weapon> Weapons { get; set; }

}
