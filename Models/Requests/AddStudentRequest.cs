namespace StudentAPI.Models.Requests
{
    public class AddStudentRequest
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Course { get; set; }
        public long PersonalID { get; set; }
    }
}
