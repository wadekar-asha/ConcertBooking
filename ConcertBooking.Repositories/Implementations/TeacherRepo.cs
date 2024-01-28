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
    public class TeacherRepo : GenericRepo<Teacher>, ITeacherRepo
    {
        private ApplicationDbContext _context;

        public TeacherRepo(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task DeleteTeacher(int id)
        {
            var teacher = await GetById(id);
            _context.Teachers.Remove(teacher);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Teacher>> GetAll()
        {
            return await _context.Teachers.ToListAsync();
        }

        public async Task<Teacher> GetById(int id)
        {
            return await _context.Teachers.Include(x => x.TeacherSubjects).FirstOrDefaultAsync(y => y.Id == id);
        }

        public async Task SaveTeacher(Teacher teacher)
        {
            await _context.Teachers.AddAsync(teacher);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateTeacher(Teacher teacher)
        {
            _context.Teachers.Update(teacher);
            await _context.SaveChangesAsync();
        }
    }
}
