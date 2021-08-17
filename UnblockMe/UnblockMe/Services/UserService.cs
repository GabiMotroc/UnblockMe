using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnblockMe.Models;

namespace UnblockMe.Services
{
    public class UserService : IUserService
    {
        private readonly UnblockMeContext _context;

        public UserService(UnblockMeContext unblockMeContext)
        {
            _context = unblockMeContext;
        }

        public User GetOwnerOfACar(Car car)
        {
            var user = _context.Users
                    .FirstOrDefault(a => a.Id.Equals(car.OwnerId));
            return user;
        }

        public async Task<User> GetOwnerOfACarAsync(Car car)
        {
            var user = await _context.Users
                    .FirstOrDefaultAsync(a => a.Id.Equals(car.OwnerId));
            return user;
        }

        public async Task<string> BlockUser(BlockedUser blockedUser)
        {
            try
            {
                await _context.AddAsync(blockedUser);
                await _context.SaveChangesAsync();
                return null;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<bool> CheckIfBlocked(string id)
        {
            var result = await _context.BlockedUser.FirstOrDefaultAsync(a => a.Id.Equals(id));
            if (result == null)
                return false;
            if (result.StartTime != null && result.StopTime == null)
                return true;
            if(result.StopTime > DateTime.UtcNow)
                return true;

            return false;
        }
    }

    public interface IUserService
    {
        Task<string> BlockUser(BlockedUser blockedUser);
        Task<bool> CheckIfBlocked(string id);
        public User GetOwnerOfACar(Car car);
        Task<User> GetOwnerOfACarAsync(Car car);
    }
}
