﻿using Microsoft.EntityFrameworkCore;
using School.API.Data;
using School.API.Dto.Hostel;
using School.MODEL;

namespace School.API.Interfaces.implementations
{
    public class HostelService : IHostelService
    {
        private readonly SchoolDbContext _schoolDbContext;

        public HostelService(SchoolDbContext schoolDbContext)
        {
            _schoolDbContext = schoolDbContext;
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

        public async Task<List<Hostel>> GetAllAsync()
        {
            return await _schoolDbContext.Hostels.OrderByDescending(x=>x.Id).ToListAsync();
        }

        public async Task<Hostel?> GetByIdAsync(long id)
        {
            return await _schoolDbContext.Hostels.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Hostel?> UpdateHostelAsync(long id, UpdateHostelDto updateHostelDto)
        {
            var hostel = await _schoolDbContext.Hostels.FindAsync(id);

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
