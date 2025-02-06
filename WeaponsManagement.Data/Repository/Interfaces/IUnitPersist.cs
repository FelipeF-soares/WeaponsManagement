using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponsManagement.Models.Place;

namespace WeaponsManagement.Data.Repository.Interfaces;

public interface IUnitPersist
{
    List<Unit> GetAll();
    Unit? GetUnitById (int id);
}
