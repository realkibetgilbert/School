using AutoMapper;
using Microsoft.EntityFrameworkCore;
using School.API.Data;
using School.API.Dto.Students;
using School.MODEL;

namespace School.API.Interfaces.studentsImplementations
{
    public class StudentService : IStudentService
    {
        private readonly SchoolDbContext _schoolDbContext;
        private readonly IMapper _mapper;

        public StudentService(SchoolDbContext schoolDbContext, IMapper mapper)
        {
            _schoolDbContext = schoolDbContext;
            _mapper = mapper;
        }

        public async Task<Student> CreateAsync(Student student)
        {
            await _schoolDbContext.Students.AddAsync(student);
            await _schoolDbContext.SaveChangesAsync();
            return student;
        }

        public async Task<Student?> DeleteAsync(long id)
        {
            var student = await _schoolDbContext.Students.FindAsync(id);
            if (student == null) return null;


            _schoolDbContext.Students.Remove(student);
            await _schoolDbContext.SaveChangesAsync();

            return student ?? null;
        }

        public async Task<List<Student>> GetAllAsync(int? pageNumber = 1, int? pageSize = 10)
        {
            var students = _schoolDbContext.Students.AsQueryable();

            var skip = (pageNumber - 1) * pageSize;
            students = students.Skip(skip ?? 0).Take(pageSize ?? 10);


            return await students.Include(h => h.Hostel).ToListAsync();

            // Map the list of students to StudentToDisplayDto
        }

        public async Task<Student?> GetByIdAsync(long id)
        {
            return await _schoolDbContext.Students.FirstOrDefaultAsync(x => x.Id == id);
            //return await _schoolDbContext.Students.FindAsync(id);
        }

        public async Task<Student?> UpdateAsync(long id, UpdateStudentDto updateStudentDto)
        {
            var student = await _schoolDbContext.Students.FindAsync(id);
            if (student == null) return null;

            student.Name = updateStudentDto.Name;
            student.RegistrationNumber = updateStudentDto.RegistrationNumber;
            student.DateOfJoin = updateStudentDto.DateOfJoin;
            student.IsActive = updateStudentDto.IsActive;


            await _schoolDbContext.SaveChangesAsync();
            return student;
        }
    }
}
