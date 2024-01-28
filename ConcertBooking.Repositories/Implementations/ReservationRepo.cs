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
    public class ReservationRepo : GenericRepo<Reservation>, IReservationRepo
    {
        private ApplicationDbContext _context;
        public ReservationRepo(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
