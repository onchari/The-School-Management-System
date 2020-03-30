using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TheSma.WebApi.Interfaces;

namespace TheSma.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassesController : ControllerBase
    {
        private readonly IClassServices _classServices;

        public ClassesController(IClassServices classServices)
        {
            _classServices = classServices;
        }

        // api/classes
        public async Task<IActionResult> GetAllClasses()
        {
            return await _classServices.GetAllClasses();
        }

        //Get /api /classes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductAsync(int id)
        {
            return await _classServices.GetClassById(id);
        }

        // api/classes/classId/streams
        [HttpGet("{classId}/streams")]
        public async Task<IActionResult> GetAllClassStreams(int classId)
        {
            return await _classServices.GetAllClassStreams(classId);
        }

    }
}