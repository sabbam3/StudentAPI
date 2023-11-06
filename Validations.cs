using StudentAPI.Models.Requests;

namespace StudentAPI
{
    public class Validations
    {
        public void ValidateGradeScoreRequest(AddStudentGradeRequest request)
        {
            if(request.Score < 0)
            {
                throw new Exception("Score should be more than 0");
            }
            if(request.Score > 100)
            {
                throw new Exception("Score should be less than 100");
            }
            
        }
    }
}
