using System.ComponentModel.DataAnnotations;

namespace School.API.Dto.Units
{
    public class UnitToCreateDto
    {
        public string UnitName { get; set; }
        public string UnitCode { get; set; }
        public bool Status { get; set; }
    }
}
