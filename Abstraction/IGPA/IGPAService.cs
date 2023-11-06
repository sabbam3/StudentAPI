namespace StudentAPI.Abstraction.IGPA
{
    public interface IGPAService
    {
        Task<double> CalculateGpaAsync(int studentId);
    }
}
