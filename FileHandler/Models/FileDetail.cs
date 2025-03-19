namespace FileHandler.Models
{
    public class FileDetail
    {
        public long Id { get; set; }
        public string FileName { get; set; }
        public string FileExtension { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
