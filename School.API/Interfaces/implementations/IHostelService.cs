using School.MODEL;

namespace School.API.Interfaces.implementations
{
    public interface IHostelService
    {
        ///mehthod do create....hostle...
        Task<Hostel> CreateAsync(Hostel hostel);
        Task<List<Hostel>> GetAllAsync();
        Task<Hostel?> DeleteAsync(long id);
        Task<Hostel?> GetByIdAsync(long id);
    }
}
