using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponsManagement.Models.People;

namespace WeaponsManagement.Models.Equipment;

public class Weapon
{
    [Key]
    public int Id { get; set; }
    [Required]
    [DisplayName("Código do Material")]
    public string  MaterialCode { get; set; }
    [Required]
    [DisplayName("Número de Patrimônio")]
    public string  PatrimonyNumber { get; set; }
    [DisplayName("Número de Série")]
    public string  SerialNumber { get; set; }
    [DisplayName("Descrição")]
    public string  Description { get; set; }
    [Required]
    [DisplayName("Valor")]
    public string  Value { get; set; }
    [Required]
    [DisplayName("Fabricante")]
    public string Factory { get; set; }
    public virtual IEnumerable<PathPictureWeapon>? PathPictures { get; set; }
    public virtual Military? Military { get; set; }
    public int UnitId { get; set; }
    
}
