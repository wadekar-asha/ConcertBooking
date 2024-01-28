using Microsoft.EntityFrameworkCore;
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
    public class ConcertRepo : GenericRepo<Concert>, IConcertRepo
    {
        private ApplicationDbContext _context;
        public ConcertRepo(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Concert>> GetAll()
        {
            var concerts = await _context.Concerts
                .Include(e => e.Venue)
                .ToListAsync();
            return (concerts);
        }

        public async Task<Concert> GetById(int id)
        {
            var concert = await _context.Concerts.FindAsync(id);
            var venue = await _context.Venues.Where(x => x.ID.Equals(concert.VenueID)).FirstAsync();
            concert.Venue.Name= venue.Name;
            concert.Venue.Address = venue.Address;
            return concert;
        }



    }
}
