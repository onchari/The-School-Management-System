using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TheSma.WebApi.Interfaces
{
    public interface IClassServices
    {
        Task<IActionResult> GetAllClasses();

        Task<IActionResult> GetAllClassStreams(int classId);

        Task<IActionResult> GetClassById(int classId);
        
        Task<IActionResult> DeleteClass(int classId);
        
    }
}
