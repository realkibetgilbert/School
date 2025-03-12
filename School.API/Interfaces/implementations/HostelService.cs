using AutoMapper;
using Microsoft.EntityFrameworkCore;
using School.API.Data;
using School.API.Dto.Hostel;
using School.MODEL;

namespace School.API.Interfaces.implementations
{
    public class HostelService : IHostelService
    {
        private readonly SchoolDbContext _schoolDbContext;
        private readonly IMapper _mapper;

        public HostelService(SchoolDbContext schoolDbContext, IMapper mapper)
        {
            _schoolDbContext = schoolDbContext;
            _mapper = mapper;
        }
        public async Task<Hostel> CreateAsync(Hostel hostel)
        {
             await _schoolDbContext.Hostels.AddAsync(hostel);
            await _schoolDbContext.SaveChangesAsync();
            return hostel;
        }

        public  async Task<Hostel?> DeleteAsync(long id)
        {
            var hostel = await _schoolDbContext.Hostels.FindAsync(id);
            if (hostel == null) return null;

            _schoolDbContext.Hostels.Remove(hostel);
            await _schoolDbContext.SaveChangesAsync();
            return hostel ?? null;
        }

        public async Task<List<Hostel>> GetAllAsync(int? pageNumber = 1, int? pageSize = 10)
        {
            var hostels = _schoolDbContext.Hostels.AsQueryable();

            var skip = (pageNumber - 1) * pageSize;
            hostels = hostels.Skip(skip ?? 0).Take(pageSize ?? 10);

            return await hostels.ToListAsync();
        }

        public async Task<Hostel?> GetByIdAsync(long id)
        {
            return await _schoolDbContext.Hostels.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Hostel?> UpdateHostelAsync(long id, UpdateHostelDto updateHostelDto)
        {
            var hostel =  await _schoolDbContext.Hostels.FindAsync(id);

            if (hostel == null) return null;

            hostel.Name = updateHostelDto.Name;
            hostel.Description = updateHostelDto.Description;
            hostel.CreatedOn = DateTime.Now;
            hostel.CreatedBy = "System";


            await _schoolDbContext.SaveChangesAsync();
            return hostel;
        }
    }
}
