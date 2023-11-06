using Microsoft.Identity.Client;

namespace StudentAPI.Models
{
    public class Grade
    {
        public int Id { get; set; }
       
        public int SubjectId { get; set; }

        public int StudentId { get; set; }
        
        public int Score { get; set; }

        public Subject Subject { get; set; }
        public Student Student { get; set; }

       
    }
}
