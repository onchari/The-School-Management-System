using System.Collections.Generic;
using System.Threading.Tasks;
using TheSma.WebApi.Models;

namespace TheSma.WebApi.Interfaces
{
    public interface IStreamRepository
    {
        Task<IEnumerable<Stream>> GetAll();
        Task<Stream> Get(int id);

        
    }
}
