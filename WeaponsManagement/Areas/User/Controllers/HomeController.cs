using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WeaponsManagement.Application.Interfaces;
using WeaponsManagement.Data.Repository.Interfaces;
using WeaponsManagement.Models.Equipment;

namespace WeaponsManagement.Areas.User.Controllers
{
    [Area("User")]
    public class HomeController : Controller
    {
        private readonly IUnitService unitService;

        public HomeController(IUnitService unitService)
        {
            this.unitService = unitService;
        }

        public IActionResult Index()
        {
            var units = unitService.GetAllUnits();
            return View(units);
        }

        public IActionResult Privacy()
        {
            return View();
        }
       
    }
}
