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
        private const string ViewName = "~/Views/Home/Index.cshtml";
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

        //public IActionResult AddCar()
        //{
        //    return View();
        //}

        public IActionResult AddCar(Car item)
        {
            try 
            {
                if (!item.Equals(null))
                {
                    this._context.Car.Add(item);
                    this._context.SaveChanges();

                    return View(ViewName);
                }
            }
            catch (Exception e)
            {
                 //nu e chiar nevoie
            }
            return View();  
        }
        

        //public ActionResult AddLicencePlate()
        //{
        //    //if (ModelState.IsValid)
        //    //{
        //    //    Car.Add(model);
        //    //    db.SaveChanges();
        //    //}
        //    return View();
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
