namespace StudentAPI.Models
{
    public class Student
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Course { get; set; }
        public long PersonalID { get; set; }
        public List<Grade> Grades { get; set; }

        public Student()
        {
            Grades = new List<Grade>();
        }
    }
}
