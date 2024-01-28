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
    public class TicketRepo : GenericRepo<Ticket>, ITicketRepo
    {
        private ApplicationDbContext _context;
        public TicketRepo(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
