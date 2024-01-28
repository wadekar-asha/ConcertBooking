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
    public class SubjectRepo : GenericRepo<Subject>, ISubjectRepo
    {
        private ApplicationDbContext _context;

        public SubjectRepo(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        //public async Task DeleteSubject(int id)
        //{
        //    var subject = await GetById(id);
        //    _context.Subjects.Remove(subject);
        //    await _context.SaveChangesAsync();
        //}

        //public async Task<IEnumerable<Subject>> GetAll()
        //{
        //    return await _context.Subjects.ToListAsync();
        //}

        //public async Task<Subject> GetById(int id)
        //{
        //    return await _context.Subjects.FindAsync(id);
        //}

        //public async Task SaveSubject(Subject subject)
        //{
        //    await _context.Subjects.AddAsync(subject);
        //    await _context.SaveChangesAsync();
        //}

        //public async Task UpdateSubject(Subject subject)
        //{
        //    _context.Subjects.Update(subject);
        //    await _context.SaveChangesAsync();
        //}
    }
}
