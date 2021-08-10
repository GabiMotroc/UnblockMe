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
using System.Text;

namespace UnblockMe.Controllers
{   
    [Authorize]
    public class CarController : Controller
    {
        private const string HomeView = "~/Views/Home/Search.cshtml";
        private const string ViewPlateView = "~/Views/Car/ViewLicencePlate.cshtml";
        private const string BlockPartial = "~/BlockCarPartialView.cshtml";
        private const string AddACarView = "~/Views/Car/AddCar.cshtml";

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

        public async Task<IActionResult> ViewLicencePlate()
        {
            var car = await _carService
                .GetCarsOfAnOwnerAsync(User.FindFirstValue(ClaimTypes.NameIdentifier));
            return View(car);
        }

        [Authorize]
        public async Task<IActionResult> AddCar(Car item)
        {
            try
            {
                if (!item.Equals(null))
                {
                    if (item.Photo != null)
                        if(item.Photo.PhotoFile != null)
                    {
                        await _carService.AddCarWithPhotoAsync(item, item.Photo.PhotoFile, User.FindFirstValue(ClaimTypes.NameIdentifier));
                        _notyfService.Success("Car succesufuly added.");
                        return View(HomeView);
                    }
                    await _carService.AddCarAndOwnerAsync(item, User.FindFirstValue(ClaimTypes.NameIdentifier));
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
            var car = new Car
            {
                Photo = new CarPhoto()
            };
            return View(AddACarView, car);
        }

        [HttpPost]
        public async Task<IActionResult> RemoveCar(string text)
        {
            try
            {
                var car = await _carService.GetCarByPlateAsync(text);
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
        public async Task<IActionResult> SearchCar(Car car)
        {
            var text = car.LicencePlate;
            if (text != null)
            {
                var Model = await _carService.GetCarByPartialPlateAsync(text);
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
        public async Task<IActionResult> SearchCar([FromQuery] string text)
        {
            if (text != null)
            {
                var cars = await _carService.GetFirstNCarsByPartialPlateAsync(text, 3);
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
        public async Task<IActionResult> EditCar(string text)
        {
            try
            {
                var car = await _carService.GetCarWithPhotoAsync(text);
                //var car = _carService.GetCarByPlate(text);
                if (car.Photo == null)
                    car.Photo = new CarPhoto();
                return PartialView("EditCarPartial", car);
            }
            catch { }
            return PartialView("EditCarPartial", null);
        }

        [HttpPost]
        public async Task<IActionResult> EditCar(Car input)
        {
            if (input.OwnerId == User.FindFirstValue(ClaimTypes.NameIdentifier))
            {
                try
                {
                    if (input.Photo == null)
                        await _carService.UpdateCarAsync(input);
                    else
                        await _carService.UpdateCarAsync(input, input.Photo.PhotoFile);
                }
                catch { }
            }
            else
            {
                Console.WriteLine("Chiar nu stiu cum reusisi");
            }
            return View(HomeView);
        }

        public async Task<IActionResult> ViewContact([FromQuery] string text)
        {
            Car car = null;
            User user = null;

            try
            {
                car = await _carService.GetCarWithPhotoAsync(text);
                user = await _userService.GetOwnerOfACarAsync(car);
                var tuple = (car, user);
                return PartialView("ViewContactPartial", tuple);
            }
            catch { }
            return PartialView("ViewContactPartial", (car, user));
        }


        public async Task<IActionResult> BlockCarPartial(string otherCar)
        {
            var plates = new List<string>();
            var cars = await _carService.GetCarsOfAnOwnerAsync(User.FindFirstValue(ClaimTypes.NameIdentifier));
            foreach (var item in cars)
            {
                plates.Add(item.LicencePlate);
            }
            BlockCarAuxiliary result = new BlockCarAuxiliary(plates, otherCar);
            return PartialView(result);
        }

        [HttpGet]
        public async Task<IActionResult> BlockCar(string ownCar, string otherCar)
        {

            var OwnCar = await _carService.GetCarByPlateAsync(ownCar);
            var OtherCar = await _carService.GetCarByPlateAsync(otherCar);
            try
            {
                if (OwnCar == null)
                {
                    OwnCar = await _carService.GetFirstCarOfOwnerAsync(User.FindFirstValue(ClaimTypes.NameIdentifier));
                }
                if (OwnCar.OwnerId == User.FindFirstValue(ClaimTypes.NameIdentifier))
                {
                    if (OtherCar != null)
                    {
                        OwnCar.Blocks = otherCar;
                        await _carService.UpdateCarAsync(OwnCar);
                        OtherCar.BockedBy = ownCar;

                        await _carService.UpdateCarAsync(OtherCar);
                        _notyfService.Success("Car blocked with success.");
                    }
                    else
                    {
                        OwnCar.Blocks = otherCar;
                        await _carService.UpdateCarAsync(OwnCar);
                        _notyfService.Warning("The selected car was not found but your status has been updated.");
                    }
                }
                else
                {
                    _notyfService.Warning("You are not the owner of the car.");
                }
            }
            catch (Exception) { }

            return View(HomeView);

        }

        public async Task<IActionResult> UnblockCar(string otherCar)
        {
            var cars = await _carService.GetCarsOfAnOwnerAsync(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var OtherCar = await _carService.GetCarByPlateAsync(otherCar);
            try
            {
                if (!cars.Equals(null) && cars.Count() > 0)
                {
                    foreach (var item in cars)
                    {
                        if (item.Blocks == otherCar)
                        {
                            item.Blocks = "";
                            await _carService.UpdateCarAsync(item);
                        }
                    }
                }
                if (OtherCar.BockedBy == cars.First().LicencePlate)
                {
                    OtherCar.BockedBy = "";
                    await _carService.UpdateCarAsync(OtherCar);
                }
            }
            catch (Exception) { }
            return View(HomeView);
        }

        public async Task<IActionResult> ExportCarsCSV()
        {
            var builder = new StringBuilder();
            builder.AppendLine($"licencePlate, maker, model, colour, blockedBy, blocks");

            var cars = await _carService.GetCarsOfAnOwnerAsync(User.FindFirstValue(ClaimTypes.NameIdentifier));
            foreach (var car in cars)
            {
                builder.AppendLine($"{car.LicencePlate}, {car.Maker}, {car.Model}, {car.Colour}, {car.BockedBy}, {car.Blocks}");
            }

            return File(Encoding.UTF8.GetBytes(builder.ToString()), "text/csv", "CarList.csv");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
