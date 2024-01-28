using ConcertBooking.Entities;
using ConcertBooking.Repositories.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertBooking.Repositories.Interfaces
{
    public interface IAddressRepo : IGenericRepo<Address>
    {
        //Task<IEnumerable<Address>> GetAll();
        //Task<Address> GetById(int id);
        //Task SaveAddress(Address address);
        //Task UpdateAddress(Address address);
        //Task DeleteAddress(int id);
    }
}
