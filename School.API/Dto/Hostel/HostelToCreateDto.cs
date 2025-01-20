using System.ComponentModel.DataAnnotations;

namespace School.API.Dto.Hostel
{
    public class HostelToCreateDto
    {
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; } = string.Empty;
        [Required]
        [StringLength(100, MinimumLength =3)]
        public string Description { get; set; } =string.Empty;
    }
}
