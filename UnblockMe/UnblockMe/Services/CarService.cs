using System;
using System.Collections.Generic;
using System.Linq;
using UnblockMe.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.EntityFrameworkCore;
using UnblockMe.Services;
using System.Security.Claims;

namespace UnblockMe.Controllers
{

    public class CarService : ICarService
    {

        private readonly UnblockMeContext _context;
        private readonly IUserService _userService;

        public CarService(UnblockMeContext unblockMeContext, IUserService userService)
        {
            _context = unblockMeContext;
            _userService = userService;
        }

        public List<Car> GetCarByPartialPlate(string licencePlate)
        {
            var cars = _context.Car
                    .Where(a => a.LicencePlate.Contains(licencePlate))
                    .ToList();

            return cars;
        }
        public async Task<List<Car>> GetCarByPartialPlateAsync(string licencePlate)
        {
            var cars = await _context.Car
                    .Where(a => a.LicencePlate.Contains(licencePlate))
                    .ToListAsync();

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
        public async Task<List<Car>> GetFirstNCarsByPartialPlateAsync(string licencePlate, int n)
        {
            var cars = await _context.Car
                    .Where(a => a.LicencePlate.Contains(licencePlate))
                    .Take(n)
                    .ToListAsync();
            return cars;
        }

        
        public Car GetCarByPlate(string licencePlate)
        {
            var car = _context.Car
                .FirstOrDefault(a => a.LicencePlate.Equals(licencePlate));
            return car;
        }
        public async Task<Car> GetCarByPlateAsync(string licencePlate)
        {
            var car = await _context.Car
                .FirstOrDefaultAsync(a => a.LicencePlate.Equals(licencePlate));
            return car;
        }


        public List<Car> GetCarsOfAnOwner(string owner)
        {
            var cars = _context.Car
                .Select(a => a)
                .Where(b => b.OwnerId == owner)
                .ToList();
            return cars;
        }
        public async Task<List<Car>> GetCarsOfAnOwnerAsync(string owner)
        {
            var cars = await _context.Car
                .Select(a => a)
                .Where(b => b.OwnerId == owner)
                .ToListAsync();
            return cars;
        }


        public void AddCarAndOwner(Car car, string v)
        {
            car.OwnerId = v;
            _context.Car.Add(car);
            _context.SaveChanges();
        }
        public async Task AddCarAndOwnerAsync(Car car, string v)
        {
            car.OwnerId = v;
            await _context.Car.AddAsync(car);
            await _context.SaveChangesAsync();
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
        public async Task<Car> GetCarWithPhotoAsync(string plate)
        {
            var car = await GetCarByPlateAsync(plate);
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
                        car.Photo = await _context.CarPhoto.Where(b => b.PhotoId.Equals(car.PhotoId)).FirstOrDefaultAsync();
                        return car;
                    }
                }
            }
            catch (Exception) { }
            return car;
        }


        public void AddPhotoToCar(Car car, IFormFile image)
        {
            try
            {
                if (car.PhotoId == null)
                {
                    Guid g = Guid.NewGuid();

                    var photo = new CarPhoto
                    {
                        PhotoId = g.ToString()//,
                        //Photo = image
                    };

                    using (var ms = new MemoryStream())
                    {
                        image.CopyTo(ms);
                        var fileBytes = ms.ToArray();
                        string s = Convert.ToBase64String(fileBytes);
                        photo.Photo = s;
                    }
                    car.PhotoId = g.ToString();
                    car.Photo = photo;
                    _context.Car.Update(car);
                    _context.CarPhoto.Add(photo);
                    _context.SaveChanges();

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public async Task AddPhotoToCarAsync(Car car, IFormFile image)
        {
            try
            {
                if (car.PhotoId == null)
                {
                    Guid g = Guid.NewGuid();

                    var photo = new CarPhoto
                    {
                        PhotoId = g.ToString()//,
                        //Photo = image
                    };

                    using (var ms = new MemoryStream())
                    {
                        image.CopyTo(ms);
                        var fileBytes = ms.ToArray();
                        string s = Convert.ToBase64String(fileBytes);
                        photo.Photo = s;
                    }
                    car.PhotoId = g.ToString();
                    car.Photo = photo;
                    _context.Car.Update(car);
                    await _context.CarPhoto.AddAsync(photo);
                    await _context.SaveChangesAsync();

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
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
        public async Task AddCarWithPhotoAsync(Car car, IFormFile image, string owner)
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
                    await _context.SaveChangesAsync();
                }
            }
            catch { }
        }


        public void UpdateCar(Car input)
        {
            _context.Car.Update(input);
            _context.SaveChanges();
        }
        public async Task UpdateCarAsync(Car input)
        {
            _context.Car.Update(input);
            await _context.SaveChangesAsync();
        }


        public void UpdateCar(Car input, IFormFile image)
        {
            try
            {
                if (input.PhotoId == null && image != null)
                {
                    AddPhotoToCar(input, image);
                    return;
                }

                if (image == null)
                {
                    UpdateCar(input);
                    return;
                }

                var carPhoto = _context.CarPhoto.Where(x => x.PhotoId.Equals(input.PhotoId)).FirstOrDefault();

                using (var ms = new MemoryStream())
                {
                    image.CopyTo(ms);
                    var fileBytes = ms.ToArray();
                    string s = Convert.ToBase64String(fileBytes);
                    carPhoto.Photo = s;
                }

                input.Photo = carPhoto;

                _context.Car.Update(input);
                _context.CarPhoto.Update(carPhoto);
                _context.SaveChanges();
            }
            catch (Exception e) 
            {
                Console.WriteLine(e);
            }
        }
        public async Task UpdateCarAsync(Car input, IFormFile image)
        {
            try
            {
                if (input.PhotoId == null && image != null)
                {
                    await AddPhotoToCarAsync(input, image);
                    return;
                }

                if (image == null)
                {
                    await UpdateCarAsync(input);
                    return;
                }

                var carPhoto = await _context.CarPhoto
                    .Where(x => x.PhotoId.Equals(input.PhotoId))
                    .FirstOrDefaultAsync();

                using (var ms = new MemoryStream())
                {
                    image.CopyTo(ms);
                    var fileBytes = ms.ToArray();
                    string s = Convert.ToBase64String(fileBytes);
                    carPhoto.Photo = s;
                }

                input.Photo = carPhoto;

                _context.Car.Update(input);
                _context.CarPhoto.Update(carPhoto);
                await _context.SaveChangesAsync();
            }
            catch (Exception) { }
        }


        public void RemoveCar(Car input)
        {
            _context.Car.Remove(input);
            _context.SaveChanges();
        }
        public async Task RemoveCarAsync(Car input)
        {
            _context.Car.Remove(input);
            await _context.SaveChangesAsync();
        }

        public async Task<Car> GetFirstCarOfOwnerAsync(string owner)
        {
            var car = await _context.Car
                .Select(a => a)
                .Where(b => b.OwnerId == owner)
                .FirstOrDefaultAsync();
            return car;
        }
    }

    public interface ICarService
    {
        public List<Car> GetCarByPartialPlate(string licencePlate);
        public Car GetCarByPlate(string licencePlate);
        void UpdateCar(Car car);
        void UpdateCar(Car input, IFormFile image);
        public void RemoveCar(Car input);
        void AddCarAndOwner(Car item, string v);
        List<Car> GetCarsOfAnOwner(string owner);
        List<Car> GetFirstNCarsByPartialPlate(string licencePlate, int n);
        void AddCarWithPhoto(Car car, IFormFile image, string owner);
        public void AddPhotoToCar(Car car, IFormFile image);

        /// <summary>
        /// Get the car and it's photo with the given licence plate.
        /// </summary>
        /// <param name="plate">The licence plate of the searched car</param>
        /// <returns>Returns Car object, together with its photography if it has one.</returns>
        Car GetCarWithPhoto(string plate);

        Task<List<Car>> GetCarByPartialPlateAsync(string licencePlate);
        Task<List<Car>> GetFirstNCarsByPartialPlateAsync(string licencePlate, int n);
        Task<Car> GetCarByPlateAsync(string licencePlate);
        Task<List<Car>> GetCarsOfAnOwnerAsync(string owner);
        Task AddCarAndOwnerAsync(Car car, string v);

        /// <summary>
        /// Asyncronous variant. 
        /// Get the car and it's photo with the given licence plate. 
        /// </summary>
        /// <param name="plate">The licence plate of the searched car</param>
        /// <returns>Returns Car object, together with its photography if it has one.</returns>
        Task<Car> GetCarWithPhotoAsync(string plate);
        Task AddPhotoToCarAsync(Car car, IFormFile image);
        Task AddCarWithPhotoAsync(Car car, IFormFile image, string owner);
        Task UpdateCarAsync(Car input);
        Task UpdateCarAsync(Car input, IFormFile image);
        Task RemoveCarAsync(Car input);
        Task<Car> GetFirstCarOfOwnerAsync(string owner);
    }
}