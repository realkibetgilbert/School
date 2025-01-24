using System.ComponentModel.DataAnnotations;

namespace School.API.Dto.Students
{
    public class StudentToCreateDto
    {
        public string Name { get; set; } 
        public string RegistrationNumber { get; set; }
        public DateTime DateOfJoin { get; set; }
        public bool IsActive { get; set; }
        public long HostelId { get; set; }
    }
}
