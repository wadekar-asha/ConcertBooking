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
    public class EmployeeRepo : GenericRepo<Employee>, IEmployeeRepo
    {
        private ApplicationDbContext _context;

        public EmployeeRepo(ApplicationDbContext context):base(context) 
        {
            _context = context;
        }
        //public async Task DeleteEmployee(int id)
        //{
        //    var employee = await GetById(id);
        //    _context.Employees.Remove(employee);
        //    await _context.SaveChangesAsync();
        //}

        public async Task<IEnumerable<Employee>> GetAll()
        {
            var emp = await _context.Employees
                .Include(e => e.Department)
                .Include(e => e.Address) //nahi ho raha hai
                .ToListAsync();
            return (emp);
        }

        public async Task<Employee> GetById(int id)
        {
            var emp = await _context.Employees.FindAsync(id);
            var addr = await _context.Addresses.Where(x => x.EmployeeId.Equals(id)).ToListAsync();
            if (addr.Count > 0)
            {
                emp.Address.AddressLine1 = addr[0].AddressLine1;
                emp.Address.AddressLine2 = addr[0].AddressLine2;
                emp.Address.EmployeeId = addr[0].EmployeeId;
            }
            else
            {
                emp.Address.AddressLine1 = "";
                emp.Address.AddressLine2 = "";
                emp.Address.EmployeeId = 0;
            }
            return await _context.Employees.FindAsync(id);
        }

        //public async Task SaveEmployee(Employee employee)
        //{
        //    await _context.Employees.AddAsync(employee);
        //    await _context.SaveChangesAsync();
        //}

        //public async Task UpdateEmployee(Employee employee)
        //{
        //    _context.Employees.Update(employee);
        //    await _context.SaveChangesAsync();
        //}
    }
}
