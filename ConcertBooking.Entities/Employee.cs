using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertBooking.Entities
{
    //Employee(1) ---------->-----(1)Department 
    public class Employee
    {        
        public int Id { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }  // Foreign Key
        //Navigation Property
        public Department Department { get; set; }       
        public Address Address { get; set; }
        public Employee()
        {
            Address = new Address();
        }
    }
}
//Employee
//Id    Name DepartmentId
//1     Ramesh      1
//2     Amit        1
