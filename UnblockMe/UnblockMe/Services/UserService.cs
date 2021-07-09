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
    }

    public interface IUserService
    {
        public User GetOwnerOfACar(Car car);
    }
}
