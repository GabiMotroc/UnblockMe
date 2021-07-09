﻿using Microsoft.AspNetCore.Mvc;
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
                var Model = _context.Car
                    .Where(a => a.LicencePlate.Contains(text))
                    .ToList();
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
        [HttpGet]
        public IActionResult EditCar(string text)
        {
            try
            {
                var car = _context.Car
                   .FirstOrDefault(a => a.LicencePlate.Equals(text));
                return PartialView("EditCarPartial", car);
            }
            catch { }
            return PartialView("EditCarPartial", null);
        }

        [HttpPost]
        public IActionResult EditCar(Car input)
        {
            if (input.OwnerId == this.User.FindFirstValue(ClaimTypes.NameIdentifier))
            {
                try
                {
                    //var car = _context.Car
                    //   .FirstOrDefault(a => a.LicencePlate == input.LicencePlate);
                    _context.Car.Update(input);
                    _context.SaveChanges();
                }
                catch { }
            }
            else
            {
                Console.WriteLine("Chiar nu stiu cum reusisi");
            }
            return View(HomeView);
        }
        public IActionResult ViewContact([FromQuery]string text)
        {
            try
            {
                var car = _context.Car
                    .FirstOrDefault(a => a.LicencePlate.Equals(text));
                var user = _context.Users
                    .FirstOrDefault(a => a.Id.Equals(car.OwnerId));
                var tuple = (car, user);
                return View(tuple);
            }
            catch { }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
