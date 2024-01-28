using Microsoft.CodeAnalysis.Diagnostics;
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
    public class AddressRepo : GenericRepo<Address>, IAddressRepo
    {
        private ApplicationDbContext _context;

        public AddressRepo(ApplicationDbContext context):base(context) 
        {
            _context = context;
        }

        //public async Task DeleteAddress(int id)
        //{
        //    var address = await GetById(id);
        //    _context.Addresses.Remove(address);
        //    await _context.SaveChangesAsync();
        //}

        //public async Task<IEnumerable<Address>> GetAll()
        //{
        //    return await _context.Addresses.ToListAsync();
        //}

        //public async Task<Address> GetById(int id)
        //{
        //    return await _context.Addresses.FindAsync(id);
        //}

        //public async Task SaveAddress(Address address)
        //{
        //    await _context.Addresses.AddAsync(address);
        //    await _context.SaveChangesAsync();
        //}

        //public async Task UpdateAddress(Address address)
        //{
        //    _context.Addresses.Update(address);
        //   await _context.SaveChangesAsync();
        //}
    }
}
