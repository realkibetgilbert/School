namespace School.API.Dto.Students
{
    public class UpdateStudentDto
    {
        public string Name { get; set; }
        public string RegistrationNumber { get; set; }
        public DateTime DateOfJoin { get; set; }
        public bool IsActive { get; set; }
    }
}
