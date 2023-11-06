using Microsoft.AspNetCore.Mvc;
using StudentAPI.Abstraction.IGrade;
using StudentAPI.Models;

namespace StudentAPI.Features.GetGrades
{
    [ApiController]
    [Route("GetGrades/[controller]")]
    public class GetController : ControllerBase
    {
        private readonly IGetGradesService _service;
 
        public GetController(IGetGradesService service)
        {
            _service = service;

        }
        [HttpGet]
        public async Task<List<GradeDto>> GetGradesAsync(int studentId)
        {
            
            return await _service.GetGradesAsync(studentId);
        }
    }
}
