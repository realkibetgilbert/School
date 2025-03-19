using School.API.Dto.Units;
using School.MODEL;

namespace School.API.Interfaces.unitsImplementations
{
    public interface IUnitService
    {
        Task<Unit> CreateAsync(Unit unit);
        Task<List<Unit>> GetAllAsync(int? pageNumber = 1, int? pageSize = 10);
        Task<Unit?> GetByIdAsync(long id);
        Task<Unit?> DeleteAsync(long id);
        Task<Unit?> UpdateUnitAsync(long id, UpdateUnitDto updateUnitDto);
    }
}
