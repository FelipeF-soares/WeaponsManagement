using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponsManagement.Models.Place;

namespace WeaponsManagement.Application.Interfaces;

public interface IUnitService
{
    void AddUnit (Unit unit);
    void UpdateUnit (int id, Unit unit);
    bool DeleteUnit (int id);
    List<Unit> GetAllUnits ();
    Unit GetUnit (int id);

}
