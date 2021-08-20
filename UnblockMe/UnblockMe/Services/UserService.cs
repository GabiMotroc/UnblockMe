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

        public async Task<string> BlockUserAsync(BlockedUsers blockedUser)
        {
            if (blockedUser.Id == null)
                blockedUser.Id = new Guid();

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

        public async Task<bool> CheckIfBlockedAsync(string id)
        {
            var result = await _context.BlockedUsers
                                    .Where(a => a.BlockedId.Contains(id))
                                    .ToListAsync();

            if(result == null)
                return false;

            if (!result.Any())
                return false;

            var latestBan = result.First();

            foreach (var user in result)
            {
                if (user.StartTime > latestBan.StartTime)
                    latestBan = user;
                
            }

            if (latestBan == null)
                return false;
            if (latestBan.StartTime != null && latestBan.StopTime == null)
                return true;
            if (latestBan.StopTime > DateTime.UtcNow)
                return true;

            return false;
        }

        public async Task<List<BlockedUsers>> GetAllBansOfUser(string id)
        {
            var result = await _context.BlockedUsers
                                    .Where(a => a.BlockedId.Contains(id))
                                    .ToListAsync();
            return result;
        }
    }

    public interface IUserService
    {
        Task<string> BlockUserAsync(BlockedUsers blockedUser);
        Task<bool> CheckIfBlockedAsync(string id);
        Task<List<BlockedUsers>> GetAllBansOfUser(string id);
        public User GetOwnerOfACar(Car car);
        Task<User> GetOwnerOfACarAsync(Car car);
    }
}
