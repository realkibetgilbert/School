namespace School.API.Models
{
    public class Student
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string RegistrationNumber { get; set; }
        public DateTime DateOfJoin { get; set; }
        public bool IsActive { get; set; }
    }
}
