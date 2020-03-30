using System.Collections.Generic;
using System.Threading.Tasks;
using TheSma.WebApi.Models;

namespace TheSma.WebApi.Interfaces
{
    public interface IClassRepository
    {
        Task<IEnumerable<Class>> GetAllClasses();


        Task<IEnumerable<Stream>> GetAllClassStreams(int classId);

        Task<Class> GetClassById(int classId);
        Task<Class> PutClass(int id, Class myclass);
        Task<Class> PostClass(Class myclass);
        Task<Class> DeleteClass(int classId);
        Task<bool> ClassExist(int id);



    }
}
