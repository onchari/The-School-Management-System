using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TheSma.WebApi.Interfaces
{
    public interface IStreamService
    {
        Task<IActionResult> GetAllStreams();
        Task<IActionResult> GetStreamById(int streamId);

        Task<IActionResult> DeleteStrean(int streamId);
       
    }
}
