using ConcertBooking.Entities;
using ConcertBooking.Repositories.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertBooking.Repositories.Interfaces
{
    public interface IReservationRepo : IGenericRepo<Reservation>
    {
    }
}
