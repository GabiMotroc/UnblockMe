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

        //public IActionResult ViewLicencePlate(string value)
        //{
        //    var cars = _context.Car.Select(a => a.LicencePlate == value);
        //    return View(cars);
        //}

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
        
        [HttpPost]
        public IActionResult RemoveCar(string value)
        {
            try 
            { 
            var car = _context.Car.Find(value);
            this._context.Car.Remove(car);
            this._context.SaveChanges();
            }
            
            catch
            {

            }
            //return View("ViewLicencePlate.cshtml");
            this.ViewLicencePlate();
            return null;
        }

        [HttpPost]
        public IActionResult SearchCar(Car car)
        {

            var text = car.LicencePlate;
            if(text != null)
            {
                var Model = _context.Car.Where(a => a.LicencePlate.Contains(text)).ToList();
                try
                {
                    if (Model.Equals(null))
                        return View(ViewName);
                }
                catch { }
                return View("ViewLicencePlate", Model);
            }
            return View(ViewName);
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
