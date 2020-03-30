using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheSma.WebApi.Interfaces;

namespace TheSma.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StreamsController : ControllerBase
    {
        private readonly IStreamService _streamService;

        public StreamsController(IStreamService streamService)
        {
            _streamService = streamService;
        }

        [HttpGet]
        // api/classes
        public async Task<IActionResult> GetAllStreams()
        {
            return await _streamService.GetAllStreams();
        }

        



    }
}