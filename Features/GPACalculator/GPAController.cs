using Microsoft.AspNetCore.Mvc;
using StudentAPI.Abstraction.IGPA;
using StudentAPI.Abstraction.IGrade;
using StudentAPI.Models;

namespace StudentAPI.Features.GPACalculator
{
    
        [ApiController]
        [Route("GetGPA/[controller]")]
        public class GPAController : ControllerBase
        {
            private readonly IGPAService _service;
        
            public GPAController(IGPAService service)
            {
                _service = service;

            }
            [HttpGet]
            public async Task<double> GPACalculatorAsync(int studentId)
            {
               return await _service.CalculateGpaAsync(studentId);
            }
            
        }
    
}
