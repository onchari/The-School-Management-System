using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheSma.WebApi.Interfaces;
using TheSma.WebApi.Models;

namespace TheSma.WebApi.Repositories
{
    public class StreamRepository : IStreamRepository
    {
        private readonly SchoolDbContext _context;

        public StreamRepository(SchoolDbContext context)
        {
            _context = context;
        }

        public Task<Stream> Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Stream>> GetAll()
        {
           return await _context.Stream.ToListAsync();
        }

        public async Task<IEnumerable<Stream>> GetAllClassStreams(int classId)
        {
           
            
            return await _context.Stream.Where(c => c.ClassId == classId).ToListAsync();
        }

        public async Task<IEnumerable<Stream>> GetAllStreamInAClass()
        {
            return await _context.Stream.ToListAsync();
        }
    }
}
