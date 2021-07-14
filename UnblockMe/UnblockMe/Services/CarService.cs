using System;
using System.Collections.Generic;
using System.Linq;
using UnblockMe.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
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
using Microsoft.AspNetCore.Http;
using System.IO;

namespace UnblockMe.Controllers
{
    public class CarService : ICarService
    {

        private readonly UnblockMeContext _context;

        public CarService(UnblockMeContext unblockMeContext)
        {
            _context = unblockMeContext;
        }

        public List<Car> GetCarByPartialPlate(string licencePlate)
        {
            var cars = _context.Car
                    .Where(a => a.LicencePlate.Contains(licencePlate))
                    .ToList();

            return cars;
        }

        public List<Car> GetFirstNCarsByPartialPlate(string licencePlate, int n)
        {
            var cars = _context.Car
                    .Where(a => a.LicencePlate.Contains(licencePlate))
                    .Take(n)
                    .ToList();
            return cars;
        }
        public Car GetCarByPlate(string licencePlate)
        {
            var car = _context.Car
                .FirstOrDefault(a => a.LicencePlate.Equals(licencePlate));
            return car;
        }

        public Car Find(string text)
        {
            return null;
        }
        public List<Car> GetCarsOfAnOwner(string owner)
        {
            var cars = _context.Car
                .Select(a => a)
                .Where(b => b.OwnerId == owner)
                .ToList();
            return cars;
        }
        public void AddCarAndOwner(Car car, string v)
        {
            car.OwnerId = v;
            _context.Car.Add(car);
            _context.SaveChanges();
        }

        public Car GetCarWithPhoto(string plate)
        {
            var car = GetCarByPlate(plate);
            try
            {
                if (car != null)
                {
                    if (car.Photo != null)
                    {
                        return car;
                    }
                    if (car.PhotoId != null)
                    {
                        car.Photo = _context.CarPhoto.Where(b => b.PhotoId.Equals(car.PhotoId)).FirstOrDefault();
                        return car;
                    }
                }
            }
            catch (Exception) { }
            return car;
        }

        public void AddPhotoToCar(string plate, IFormFile image)
        {
            var car = GetCarByPlate(plate);
            try
            {
                if (car.PhotoId == null)
                {
                    Guid g = Guid.NewGuid();

                    CarPhoto photo = new CarPhoto
                    {
                        PhotoId = g.ToString()//,
                        //Photo = image
                    };

                    car.PhotoId = g.ToString();

                    _context.Car.Update(car);
                    _context.CarPhoto.Add(photo);
                    _context.SaveChanges();

                }
            }
            catch { }
        }

        public void AddCarWithPhoto(Car car, IFormFile image, string owner)
        {
            try
            {
                if (car != null && image != null)
                {
                    Guid g = Guid.NewGuid();
                    car.PhotoId = g.ToString();
                    car.OwnerId = owner;
                    var carPhoto = car.Photo;
                    carPhoto.PhotoId = g.ToString();

                    using (var ms = new MemoryStream())
                    {
                        image.CopyTo(ms);
                        var fileBytes = ms.ToArray();
                        string s = Convert.ToBase64String(fileBytes);
                        carPhoto.Photo = s;
                    }

                    _context.Car.Add(car);
                    _context.CarPhoto.Add(carPhoto);
                    _context.SaveChanges();
                }
            }
            catch { }
        }
        public void UpdateCar(Car input)
        {
            _context.Car.Update(input);
            _context.SaveChanges();
        }

        public void UpdateCar(Car input, IFormFile image)
        {
            try
            {
                if (input.PhotoId == null && image != null)
                {
                    AddCarWithPhoto(input, image, input.OwnerId);
                    return;
                }

                if (image == null)
                    UpdateCar(input);

                var carPhoto = _context.CarPhoto.Where(x => x.PhotoId.Equals(input.PhotoId)).FirstOrDefault();

                using (var ms = new MemoryStream())
                {
                    image.CopyTo(ms);
                    var fileBytes = ms.ToArray();
                    string s = Convert.ToBase64String(fileBytes);
                    carPhoto.Photo = s;
                }

                _context.Car.Update(input);
                _context.CarPhoto.Update(carPhoto);
                _context.SaveChanges();
            }
            catch (Exception) { }
        }

        public void RemoveCar(Car input)
        {
            _context.Car.Remove(input);
            _context.SaveChanges();
        }
    }

    public interface ICarService
    {
        public List<Car> GetCarByPartialPlate(string licencePlate);
        public Car GetCarByPlate(string licencePlate);
        void UpdateCar(Car car);
        public void RemoveCar(Car input);
        void AddCarAndOwner(Car item, string v);
        List<Car> GetCarsOfAnOwner(string owner);
        List<Car> GetFirstNCarsByPartialPlate(string licencePlate, int n);
        void AddCarWithPhoto(Car car, IFormFile image, string owner);
        void AddPhotoToCar(string plate, IFormFile image);
        void UpdateCar(Car input, IFormFile image);
        Car GetCarWithPhoto(string plate);
    }
}