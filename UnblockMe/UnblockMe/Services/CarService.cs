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
        public void UpdateCar(Car input)
        {
            _context.Car.Update(input);
            _context.SaveChanges();
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
    }
}