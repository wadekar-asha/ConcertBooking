using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertBooking.Entities
{
    public class Ticket
    {
        public int ID { get; set; }
        public int ConcertID { get; set; }
        public Concert Concert { get; set; }
        public float Price { get; set; }
        public string Status { get; set; }  
    }
}
