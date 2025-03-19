using School.API.Dto.Students;
using School.MODEL;

namespace School.API.Interfaces.studentsImplementations
{
    public interface IStudentService
    {
        Task<Student> CreateAsync(Student student);
        Task<List<Student>> GetAllAsync(int? pageNumber = 1, int? pageSize = 10);
        Task<Student?> GetByIdAsync(long id);
        Task<Student?> DeleteAsync(long id);
        Task<Student?> UpdateAsync(long id, UpdateStudentDto updateStudentDto);
    }
}
