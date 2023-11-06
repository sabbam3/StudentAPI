using Microsoft.AspNetCore.Mvc;
using StudentAPI.Abstraction.ISubject;
using StudentAPI.Models.Requests;

namespace StudentAPI.Features.AddSubject
{
    [ApiController]
    [Route("addSubject/[controller]")]
    public class AddController : ControllerBase
    
    {
        private readonly IAddSubjectService _addSubjectService;

        public AddController(IAddSubjectService addSubjectService)
        {
            _addSubjectService = addSubjectService;
        }
        [HttpPost]
        public async Task AddSubjectAsync(AddSubjectRequest request)
        {
            await _addSubjectService.AddSubjectAsync(request);
        }
    }
}
