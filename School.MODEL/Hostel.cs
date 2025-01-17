namespace School.MODEL
{
    public class Hostel : Base
    {
        public long Id { get; set; }
        public required string Name { get; set; }
        public string Description { get; set; }
    }
}
