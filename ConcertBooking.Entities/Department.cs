using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertBooking.Entities
{


    //Department(1)-------->------(*)Employee
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Navigation Property
        public ICollection<Employee> Employyees { get; set; }

    }
}
//Department 
//ID Name
//1  IT
