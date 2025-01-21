using Microsoft.EntityFrameworkCore;
using School.API.Data;
using School.API.Dto.Units;
using School.MODEL;

namespace School.API.Interfaces.unitsImplementations
{
    public class UnitService : IUnitService
    {
        private readonly SchoolDbContext _schooDbContext;

        public UnitService(SchoolDbContext schooDbContext)
        {
            _schooDbContext = schooDbContext;
        }

        public async Task<Unit> CreateAsync(Unit unit)
        {
            await _schooDbContext.Units.AddAsync(unit);
            await _schooDbContext.SaveChangesAsync(); 
            return unit;
        }

        public async Task<Unit?> DeleteAsync(long id)
        {
            var unit = await _schooDbContext.Units.FindAsync(id);
            if (unit == null) return null;
            
            _schooDbContext.Units.Remove(unit);
            await _schooDbContext.SaveChangesAsync();

            return unit ?? null;
        }

        public async Task<List<Unit>> GetAllAsync()
        {
            return await _schooDbContext.Units.ToListAsync();
        }

        public async Task<Unit?> GetByIdAsync(long id)
        {
            return await _schooDbContext.Units.FindAsync(id);
        }

        public async Task<Unit?> UpdateUnitAsync(long id, UpdateUnitDto updateUnitDto)
        {
            var unit = await _schooDbContext.Units.FindAsync(id);
            if (unit is null) return null;
            
            unit.UnitName = updateUnitDto.UnitName;
            unit.UnitCode = updateUnitDto.UnitCode;
            unit.Status = updateUnitDto.Status;
            unit.CreatedOn = DateTime.Now;
            unit.CreatedBy = "system";

            await _schooDbContext.SaveChangesAsync();
            return unit;
        }
    }
}
