using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheSma.WebApi.Interfaces;
using TheSma.WebApi.Models;

namespace TheSma.WebApi.Services
{
    public class StreamService : IStreamService
    {
        private readonly IStreamRepository _streamRepository;

        public StreamService(IStreamRepository streamRepository)
        {
            _streamRepository = streamRepository;
        }
        public async Task<IActionResult> GetAllStreams()
        {
            IEnumerable<Stream> streams = await _streamRepository.GetAll();
            if(streams == null)
            {
                return new NotFoundResult();
            }
            else
            {
                return new OkObjectResult(streams);
            }
        }


       
        public Task<IActionResult> DeleteStrean(int streamId)
        {
            throw new System.NotImplementedException();
        }

       

        public Task<IActionResult> GetStreamById(int streamId)
        {
            throw new System.NotImplementedException();
        }

        
    }
}
