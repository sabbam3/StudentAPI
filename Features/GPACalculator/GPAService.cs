using StudentAPI.Abstraction.IGPA;
using System.Drawing;

namespace StudentAPI.Features.GPACalculator
{
    public class GPAService : IGPAService
    {
        private readonly IGPARepository _repository;
        public GPAService(IGPARepository repository)
        {
            _repository = repository;
        }
        public async Task<double> CalculateGpaAsync(int studentId)
        {
            return await _CalculateGradePoints(studentId) / await _SubjectCreditSum(studentId);   
        }
        private async Task<double> _CalculateGradePoints(int studentId)
        {
            List<int> subjectIdList = await _repository.GetStudentSubjectIdListAsync(studentId);
            double gradePoint = 0;
            foreach (var subjectId in subjectIdList)
            {
                gradePoint += await _PointsToGrade(studentId, subjectId) * await _repository.GetSubjectCreditAsync(studentId, subjectId);
            }
            return gradePoint;
        }

        private async Task<double> _PointsToGrade(int studentId, int subjectId)
        {
            var studentPoint = await _repository.GetStudentPointAsync(studentId, subjectId);
            double pointToGrade = 0;
            if (studentPoint < 51) pointToGrade = 0;
            if (studentPoint > 50 && studentPoint < 61) pointToGrade = 0.5;
            if (studentPoint > 60 && studentPoint < 71) pointToGrade = 1;
            if (studentPoint > 70 && studentPoint < 81) pointToGrade = 2;
            if (studentPoint > 80 && studentPoint < 91) pointToGrade = 3;
            if (studentPoint > 90) pointToGrade = 4;
            return pointToGrade;
        }
        private async Task<int> _SubjectCreditSum(int studentId)
        {
            var subjectCredit = await _repository.GetSubjectCreditsAsync(studentId);
            int subjectCreditSum = 0;
            foreach(var credit in subjectCredit)
            {
                subjectCreditSum += credit;
            }
            return subjectCreditSum;
        }

    }
}
