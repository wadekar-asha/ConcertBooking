using ConcertBooking.Entities;
using ConcertBooking.Repositories.Generic;
using ConcertBooking.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertBooking.Repositories.Implementations
{
    public class UserRepo : GenericRepo<User>, IUserRepo
    {
        private ApplicationDbContext _context;
        public UserRepo(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
