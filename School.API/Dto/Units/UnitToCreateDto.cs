namespace School.API.Dto.Units
{
    public class UnitToCreateDto
    {
        public required string UnitName { get; set; }
        public required string UnitCode { get; set; }
        public bool Status { get; set; }
    }
}
