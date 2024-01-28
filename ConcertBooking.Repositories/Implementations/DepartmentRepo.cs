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
    public class DepartmentRepo :GenericRepo<Department>, IDepartmentRepo
    {
        private ApplicationDbContext _context;

        public DepartmentRepo(ApplicationDbContext context):base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Department>> Search(string name)
        {
            return await _context.Departments.Where(x=>x.Name.Contains(name)).ToListAsync();
        }

        //public void DeleteDepartment(int id)
        //{
        //    var department = GetById(id);
        //    _context.Departments.Remove(department);
        //    _context.SaveChanges();
        //}

        //public async Task<IEnumerable<Department>> GetAll()
        //{
        //    return await  _context.Departments.ToListAsync();
        //}

        //public Department GetById(int id)
        //{
        //    return _context.Departments.Find(id);
        //}

        //public async Task SaveDepartment(Department department)
        //{
        //   await  _context.Departments.AddAsync(department);
        //   await  _context.SaveChangesAsync();
        //}

        //public void UpdateDepartment(Department department)
        //{
        //    _context.Departments.Update(department);
        //    _context.SaveChanges();
        //}
    }
}
