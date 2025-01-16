namespace School.API.Models
{
    public class Student:Base
    {
        public long Id { get; set; }
        public required string Name { get; set; }
        public required string RegistrationNumber { get; set; }
        public DateTime DateOfJoin { get; set; }
        public bool IsActive { get; set; }
    }
}
