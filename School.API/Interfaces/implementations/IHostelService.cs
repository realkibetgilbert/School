using School.API.Dto.Hostel;
using School.MODEL;

namespace School.API.Interfaces.implementations
{
    public interface IHostelService
    {
        ///mehthod to create....hostel...
        Task<Hostel> CreateAsync(Hostel hostel);
        Task<List<Hostel>> GetAllAsync(int? pageNumber = 1, int? pageSize = 10);
        Task<Hostel?> DeleteAsync(long id);
        Task<Hostel?> GetByIdAsync(long id);
        Task<Hostel?> UpdateHostelAsync(long id, UpdateHostelDto updateHostelDto);
    }
}
