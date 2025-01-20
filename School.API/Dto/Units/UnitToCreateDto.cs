using System.ComponentModel.DataAnnotations;

namespace School.API.Dto.Units
{
    public class UnitToCreateDto
    {
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public required string UnitName { get; set; }
        [Required]
        [StringLength (100, MinimumLength = 3)]
        public required string UnitCode { get; set; }
        [Required]
        public bool Status { get; set; }
    }
}
