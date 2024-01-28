using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertBooking.Entities
{
    public class Reservation
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public int TicketID { get; set; }
        public Ticket Ticket { get; set; }
        public DateTime ReservationDate { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
