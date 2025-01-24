namespace School.API.Dto.Units
{
    public class UnitToDisplayDto
    {
        public long Id { get; set; }
        public required string UnitName { get; set; }
        public required string UnitCode { get; set; }
        public bool Status { get; set; }
    }
}
