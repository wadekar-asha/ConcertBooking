using Microsoft.EntityFrameworkCore;
using ConcertBooking.Entities;
using ConcertBooking.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertBooking.Repositories.Implementations
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _Context;

        public UserService(ApplicationDbContext context)
        {
            _Context = context;
        }

        public async Task<UserInfo> Login(string userName, string password)
        {
            return await _Context.UserInfos.FirstOrDefaultAsync(x => x.UserName == userName && x.Password == password);
        }

        public async Task Register(UserInfo userInfo)
        {
            bool isExist = await Exists(userInfo.UserName);
            if (!isExist)
            {
                await _Context.UserInfos.AddAsync(userInfo);
                await _Context.SaveChangesAsync();
            }
        }
        public async Task<bool> Exists(string userName)
        {
            return _Context.UserInfos.Any(x => x.UserName == userName);            
        }
    }
}
