using System.ComponentModel.DataAnnotations;

namespace School.API.Dto.Students
{
    public class StudentToCreateDto
    {
        [Required(ErrorMessage = "weka jina")]
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; } = string.Empty;
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string RegistrationNumber { get; set; } = string.Empty;
        [Required]
        public DateTime DateOfJoin { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        public long HostelId { get; set; }
    }
}
