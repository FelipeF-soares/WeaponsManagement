using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WeaponsManagement.Data.Repository.Interfaces;
using WeaponsManagement.Models.Equipment;

namespace WeaponsManagement.Areas.User.Controllers
{
    
    public class HomeController : Controller
    {
        
        private readonly IWeaponPersist weaponPersist;

        public HomeController( IWeaponPersist weaponPersist)
        {
            this.weaponPersist = weaponPersist;
        }

        public IActionResult Index()
        {
           List<Weapon> weapons = weaponPersist.GetAllWeapons();
            return View(weapons);
        }

        public IActionResult Privacy()
        {
            return View();
        }
       
    }
}
