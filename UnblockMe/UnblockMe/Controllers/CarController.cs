using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using UnblockMe.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.Data.SqlClient;

namespace UnblockMe.Controllers
{
    public class CarController : Controller
    {
        private const string HomeView = "~/Views/Home/Search.cshtml";
        private const string ViewPlateView = "~/Views/Car/ViewLicencePlate.cshtml";
        private readonly ILogger<CarController> _logger;
        private readonly UnblockMeContext _context;
        private readonly INotyfService _notyfService;

        public CarController(UnblockMeContext unlockMeContext, ILogger<CarController> logger, INotyfService notyfService)
        {
            _logger = logger;
            _context = unlockMeContext;
            _notyfService = notyfService;
        }

        public IActionResult ViewLicencePlate()
        {
            var cars = _context.Car
                .Select(a => a)
                .Where(b => b.OwnerId == this.User.FindFirstValue(ClaimTypes.NameIdentifier))
                .ToList();
            return View(cars);
        }

        [Authorize]
        public IActionResult AddCar(Car item)
        {
            try
            {
                if (!item.Equals(null))
                {

                    item.OwnerId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);/*User.Identity.GetUserId();*/
                    this._context.Car.Add(item);
                    this._context.SaveChanges();
                    _notyfService.Success("Car succesufuly added.");
                    return View(HomeView);
                }
            }
            //catch (SqlException e)
            //    when (e.Number == 2627)
            //    {
            //    _notyfService.Warning("The licence plate already exists.");
            //    }
            catch (Exception e)
                        when ((bool)(e.InnerException?.ToString().Contains("PRIMARY KEY")))
            {
                _notyfService.Warning("The licence plate already exists.");
            }
            catch (Exception)
            {

            }
            return View();
        }

        [HttpPost]
        public IActionResult RemoveCar(string text)
        {
            //var text = model.LicencePlate;
            try
            {
                var car = _context.Car.Find(text);
                this._context.Car.Remove(car);
                this._context.SaveChanges();
            }
            catch
            {

            }
            return View(HomeView);
            //this.ViewLicencePlate();
            //return this.ViewLicencePlate();
        }

        [HttpPost]
        public IActionResult SearchCar(Car car)
        {
            var text = car.LicencePlate;
            if (text != null)
            {
                var Model = _context.Car.Where(a => a.LicencePlate.Contains(text)).ToList();
                try
                {
                    if (Model.Equals(null))
                    {
                        return View(HomeView);
                    }
                }
                catch { }
                return View("ViewLicencePlate", Model);
            }
            return View(HomeView);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
