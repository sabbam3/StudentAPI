using StudentAPI.Models;

namespace StudentAPI.Abstraction.IGrade
{
    public interface IGetGradesService
    {
        Task<List<GradeDto>> GetGradesAsync(int studentId);
    }
}
