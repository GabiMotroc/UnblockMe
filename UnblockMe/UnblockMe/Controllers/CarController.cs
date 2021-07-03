using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnblockMe.Models;

namespace UnblockMe.Controllers
{
    public class CarController : Controller
    {
        private readonly UnblockMeContext _context;
        public CarController(UnblockMeContext unlockMeContext)
        {
            _context = unlockMeContext;
        }

        public IActionResult ViewLicencePlate()
        {
            var cars = _context.Car.Select(car => car).ToList();
            return View(cars);
        }

        public IActionResult AddLicencePlate()
        {
            return View();
        }
    }
}
