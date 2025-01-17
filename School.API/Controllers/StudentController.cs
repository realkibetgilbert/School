using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using School.API.Data;
using School.API.Dto.Students;
using School.MODEL;

namespace School.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly SchoolDbContext schoolDbContext;

        public StudentController(SchoolDbContext schoolDbContext)
        {
            this.schoolDbContext = schoolDbContext;
        }
        //https://localhost.com/api/Student/Create
        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] StudentToCreateDto studentToCreateDto)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); };
            //dto for us to save in db we neeed to map to table.....model
            var student = new Student
            {
                Name = studentToCreateDto.Name,
                RegistrationNumber = studentToCreateDto.RegistrationNumber,
                HostelId = studentToCreateDto.HostelId,
                DateOfJoin = studentToCreateDto.DateOfJoin,
                IsActive = studentToCreateDto.IsActive,
                CreatedOn = DateTime.Now,
                CreatedBy = "system",
            };
            await schoolDbContext.Students.AddAsync(student);
            await schoolDbContext.SaveChangesAsync();
            return Ok(student);
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await schoolDbContext.Students.Include(h=>h.Hostel).ToListAsync());
        }

        [HttpGet]
        [Route("{id:long}")]
        public async Task<IActionResult> GetAsyncById(long id)
        {

            var student = schoolDbContext.Students.Find(id);
            if (student == null)
            {
                return NotFound();
            }

            return Ok(await schoolDbContext.Students.FindAsync(id));
        }

        [HttpPut]
        [Route("{id:long}")]
        public async Task<IActionResult> PutAsyncById(long id, UpdateStudentDto updateStudentDto)
        {
            
            var student = schoolDbContext.Students.Find(id);
            if (student == null) 
            {
                return NotFound();
            }
            {
                student.Name = updateStudentDto.Name;
                student.RegistrationNumber = updateStudentDto.RegistrationNumber;
                student.DateOfJoin = updateStudentDto.DateOfJoin;
                student.IsActive = updateStudentDto.IsActive;
                student.CreatedOn = DateTime.Now;
                student.CreatedBy = "system";
            };

            await schoolDbContext.SaveChangesAsync();
            return Ok(student);
        }

        [HttpDelete]
        [Route("{id:long}")]
        public async Task<IActionResult> DeleteAsync(long id)
        {
            var student = await schoolDbContext.Students.FindAsync(id);



             schoolDbContext.Students.Remove(student);
            await schoolDbContext.SaveChangesAsync();   

            return Ok();
        }

    }
}

