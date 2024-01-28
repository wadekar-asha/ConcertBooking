using ConcertBooking.Entities;
using ConcertBooking.Repositories.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertBooking.Repositories.Interfaces
{
    public interface IEmployeeRepo :  IGenericRepo<Employee>
    {
        //Task<IEnumerable<Employee>> GetAll();
        //Task<Employee> GetById(int id);
        //Task SaveEmployee(Employee employee);
        //Task UpdateEmployee(Employee employee);
        //Task DeleteEmployee(int id);
    }
}
