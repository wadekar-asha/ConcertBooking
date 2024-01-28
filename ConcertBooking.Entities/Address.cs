using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertBooking.Entities
{
    //Employee(1) --------------(1)Address
    public class Address
    {
        public int Id { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public int EmployeeId { get; set; } // Unique Key
        public Employee Employee { get; set; }
    }
}
