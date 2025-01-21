using System.ComponentModel.DataAnnotations;

namespace School.API.Dto.Students
{
    public class StudentToDisplayDto
    {
        public long Id { get; set; }
        public string RegistrationNumber { get; set; } 
        public DateTime DateOfJoin { get; set; }
        public bool IsActive { get; set; }

    }
}
