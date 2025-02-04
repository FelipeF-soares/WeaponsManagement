using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponsManagement.Models.Place;

public abstract class Address
{
    [Required]
    [DisplayName("Endereço")]
    public string Street { get; set; }
    [Required]
    [DisplayName("Numero")]
    public string Number { get; set; }
    [Required]
    [DisplayName("Bairro")]
    public string Neighborhood { get; set; }
    [Required]
    [DisplayName("Cidade")]
    public string City { get; set; }
    [Required]
    [DisplayName("Estado")]
    public string State { get; set; }
    [Required]
    [DisplayName("CEP")]
    public string ZIPCode { get; set; }
}
