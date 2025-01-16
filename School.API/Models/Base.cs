namespace School.API.Models
{
    public class Base
    {
        public DateTime CreatedOn{ get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
