using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponsManagement.Models.People;

namespace WeaponsManagement.Data.Repository.Interfaces;

public interface IMilitaryPersist
{
    List<Military> GetAllMilitaries ();
    Military? GetMilitaryById (int id);
}
