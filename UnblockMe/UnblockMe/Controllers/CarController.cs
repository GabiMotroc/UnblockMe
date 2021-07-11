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
using UnblockMe.Services;

namespace UnblockMe.Controllers
{
    public class CarController : Controller
    {
        private const string HomeView = "~/Views/Home/Search.cshtml";
        private const string ViewPlateView = "~/Views/Car/ViewLicencePlate.cshtml";
        private const string BlockPartial = "~/BlockCarPartialView.cshtml";

        private readonly ICarService _carService;
        private readonly IUserService _userService;
        private readonly ILogger<CarController> _logger;
        private readonly INotyfService _notyfService;

        public CarController(ICarService carService, IUserService userService, ILogger<CarController> logger, INotyfService notyfService)
        {
            _carService = carService;
            _userService = userService;
            _logger = logger;
            _notyfService = notyfService;
        }

        public IActionResult ViewLicencePlate()
        {
            return View(_carService
                .GetCarsOfAnOwner(User.FindFirstValue(ClaimTypes.NameIdentifier)));
        }

        [Authorize]
        public IActionResult AddCar(Car item)
        {
            try
            {
                if (!item.Equals(null))
                {

                    _carService.AddCarAndOwner(item, User.FindFirstValue(ClaimTypes.NameIdentifier));
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
            try
            {
                var car = _carService.GetCarByPlate(text);
                if (car.OwnerId == User.FindFirstValue(ClaimTypes.NameIdentifier))
                {
                   _carService.RemoveCar(car);
                }
                else 
                {
                    Console.WriteLine("you are not the owner of ths car");
                }
            }
            catch
            {

            }
            return View(HomeView);
        }

        [HttpPost]
        public IActionResult SearchCar(Car car)
        {
            var text = car.LicencePlate;
            if (text != null)
            {
                var Model = _carService.GetCarByPartialPlate(text);
                try
                {
                    if (Model.Equals(null))
                    {
                        return View(HomeView, Model);
                    }
                }
                catch { }
                return View("ViewLicencePlate", Model);
            }
            return View(HomeView, null);
        }

        [HttpGet]
        public IActionResult SearchCar([FromQuery] string text)
        {
            if (text != null)
            {
                var cars = _carService.GetCarByPartialPlate(text);
                try
                {
                    if (!cars.Equals(null))
                    {
                        return View(HomeView, cars);
                    }
                }
                catch { }
            }
            return View(HomeView, null);
        }
        [HttpGet]
        public IActionResult EditCar(string text)
        {
            try
            {
                var car = _carService.GetCarByPlate(text);
                return PartialView("EditCarPartial", car);
            }
            catch { }
            return PartialView("EditCarPartial", null);
        }

        [HttpPost]
        public IActionResult EditCar(Car input)
        {
            if (input.OwnerId == User.FindFirstValue(ClaimTypes.NameIdentifier))
            {
                try
                {
                    _carService.UpdateCar(input);
                }
                catch { }
            }
            else
            {
                Console.WriteLine("Chiar nu stiu cum reusisi");
            }
            return View(HomeView);
        }

        public IActionResult ViewContact([FromQuery] string text)
        {
            Car car = null;
            User user = null;

            try
            {
                car = _carService.GetCarByPlate(text);
                user = _userService.GetOwnerOfACar(car);
                var tuple = (car, user);
                return PartialView("ViewContactPartial", tuple);
            }
            catch { }
            return PartialView("ViewContactPartial", (car, user));
        }

        public IActionResult BlockCar()
        {
            return PartialView("BlockCarPartial");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
