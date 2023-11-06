using Microsoft.AspNetCore.Mvc;
using StudentAPI.Abstraction.IStudent;
using StudentAPI.Models.Requests;

namespace StudentAPI.Features.AddStudent
{
    [ApiController]
    [Route("addstudent/[controller]")]
    public class AddController : ControllerBase
    {
        private readonly IAddStudentService _addStudentService;
        public AddController(IAddStudentService addStudentService)
        {
            _addStudentService = addStudentService;
        }
        [HttpPost]
        public async Task AddStudentAsync(AddStudentRequest request)
        {
            await _addStudentService.AddStudentAsync(request);
        }
        
    }
}
