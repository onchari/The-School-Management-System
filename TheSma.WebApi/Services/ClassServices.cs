using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheSma.WebApi.Interfaces;
using TheSma.WebApi.Models;
using TheSma.WebApi.ViewModels;

namespace TheSma.WebApi.Services
{
    public class ClassServices : IClassServices
    {
        private readonly IClassRepository _classRepository;

        public ClassServices(IClassRepository classRepository)
        {
            _classRepository = classRepository;
        }


        public async Task<IActionResult> GetAllClasses()
        {
            try
            {
                IEnumerable<Class> classes = await _classRepository.GetAllClasses();
                if(classes == null)
                {
                    return new NotFoundResult();
                }
                else
                {
                    var viewModel = classes.Select(myclass => new ClassViewModel()
                    {
                        VmId = myclass.ClassId,
                        VmName = myclass.Name,
                        VmStreams = myclass.Streams,
                        VmStudents = myclass.Students                  
                    });

                    return new OkObjectResult(viewModel);

                }

            }
            catch (Exception)
            {

                return new ConflictResult();
            }
        }


        public async Task<IActionResult> GetClassById(int classId)
        {
            try
            {
                Class myclass = await _classRepository.GetClassById(classId);
                if(myclass == null)
                {
                    return new NotFoundResult();
                }
                else
                {
                    return new OkObjectResult(myclass);
                }
            }
            catch (Exception)
            {

                return new ConflictResult();
            }


        }

        public Task<IActionResult> DeleteClass(int classId)
        {
            throw new NotImplementedException();
        }

        public async Task<IActionResult> GetAllClassStreams(int classId)
        {
            var streams = await _classRepository.GetAllClassStreams(classId);
            
            var streamVm = new List<StreamViewModel>();

            foreach(var stream in streams)
            {
                streamVm.Add(new StreamViewModel
                {
                    Id = stream.StreamId,
                    Name = stream.StreamName,
                    ClassId = stream.ClassId,
                    ClassName = "Class Name"
                }) ;
            }
            return  new OkObjectResult(streamVm);
        }
    }
}
