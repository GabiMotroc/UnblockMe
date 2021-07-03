using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using UnblockMe.Models;

namespace UnblockMe.Controllers
{
    public class CarController : Controller
    {
        private readonly ILogger<CarController> _logger;
        private readonly UnblockMeContext _context;

        public CarController(UnblockMeContext unlockMeContext, ILogger<CarController> logger)
        {
            _logger = logger;
            _context = unlockMeContext;
        }

        public IActionResult ViewLicencePlate()
        {
            var cars = _context.Car.Select(a => a).ToList();
            return View(cars);
        }

        public IActionResult AddLicencePlate()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
