using StudentAPI.Models;

namespace StudentAPI.Abstraction.IGrade
{
    public interface IGetGradesRepository
    {
        Task<List<Grade>> GetGradesAsync(int studentId);
    }
}
