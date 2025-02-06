using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponsManagement.Models.People;

namespace WeaponsManagement.Application.Interfaces;

public interface IMilitaryService
{
    void AddMilitary (Military military);
    void UpdateMilitary (int id, Military military);
    bool DeleteMilitary (int id);
    List<Military> GetAllMilitary ();
    Military GetMilitaryById (int id);
}
