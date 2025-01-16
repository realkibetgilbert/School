using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using School.API.Data;
using School.API.Dto.Students;
using School.API.Models;

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
            //dto for us to save in db we neeed to map to table.....model
            var student = new Student
            {
                Name = studentToCreateDto.Name,
                RegistrationNumber = studentToCreateDto.Name,
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
            return Ok(await schoolDbContext.Students.ToListAsync());
        }       

    }
}

