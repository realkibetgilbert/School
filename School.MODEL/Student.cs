namespace School.MODEL
{
    public class Student : Base
    {
        public long Id { get; set; }
        public  string Name { get; set; }
        public  string RegistrationNumber { get; set; }
        public DateTime DateOfJoin { get; set; }
        public bool IsActive { get; set; }
        public long HostelId { get; set; }
        public Hostel Hostel { get; set; }
    }
}
