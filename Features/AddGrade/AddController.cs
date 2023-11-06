using Microsoft.AspNetCore.Mvc;
using StudentAPI.Abstraction.IGrade;
using StudentAPI.Models.Requests;

namespace StudentAPI.Features.AddGrade
{
    [ApiController]
    [Route("addGrade/[controller]")]
    public class AddController : ControllerBase
    {
        private readonly IAddStudentGradeService _addStudentGradeService;
        private readonly Validations _validations;
        public AddController(IAddStudentGradeService addStudentGradeService, Validations validations)  
        {
            _addStudentGradeService = addStudentGradeService;
            _validations = validations;
        }
        [HttpPost]
        public async Task AddGradeAsync(int studentId, AddStudentGradeRequest request)
        {
           _validations.ValidateGradeScoreRequest(request);
           await _addStudentGradeService.AddGradeAsync(studentId, request);
        }
    }
}
