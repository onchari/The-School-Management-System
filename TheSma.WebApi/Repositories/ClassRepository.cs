using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheSma.WebApi.Interfaces;
using TheSma.WebApi.Models;

namespace TheSma.WebApi.Repositories
{
    public class ClassRepository : IClassRepository
    {
        private readonly SchoolDbContext _context;

        public ClassRepository(SchoolDbContext context)
        {
            _context = context;
        }

        //Get all classes
        public async Task<IEnumerable<Class>> GetAllClasses()
        {
            return await _context.Classes.ToListAsync();
        }

        //Get a class by Id
        public async Task<Class> GetClassById(int classId)
        {
            return await _context.Classes.Where(c => c.ClassId == classId).FirstOrDefaultAsync();
        }

        public Task<bool> ClassExist(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Class> DeleteClass(int classId)
        {
            throw new NotImplementedException();
        }

             

        public Task<Class> PostClass(Class myclass)
        {
            throw new NotImplementedException();
        }

        public Task<Class> PutClass(int id, Class myclass)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Stream>> GetAllClassStreams(int classId)
        {
            return await _context.Stream.Where(c => c.Class.ClassId == classId).ToListAsync();
        }
    }
}
