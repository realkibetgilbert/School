using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using School.API.Data;
using School.API.Dto.Students;
using School.API.Interfaces.studentsImplementations;
using School.API.Migrations;
using School.MODEL;

namespace School.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly SchoolDbContext schoolDbContext;
        private readonly IStudentService _studentService;

        public StudentController(SchoolDbContext schoolDbContext, IStudentService studentService)
        {
            this.schoolDbContext = schoolDbContext;
            _studentService = studentService;
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
            return Ok(await _studentService.CreateAsync(student));
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await _studentService.GetAllAsync());
        }

        [HttpGet]
        [Route("{id:long}")]
        public async Task<IActionResult> GetAsyncById(long id)
        {
            return Ok( await _studentService.GetByIdAsync(id));
        }

        [HttpPut]
        [Route("{id:long}")]
        public async Task<IActionResult> PutAsyncById(long id, UpdateStudentDto updateStudentDto)
        {
            var result = await _studentService.UpdateAsync(id, updateStudentDto);
            if (result is null) return NotFound();

            return Ok(result);
           
        }

        [HttpDelete]
        [Route("{id:long}")]
        public async Task<IActionResult> DeleteAsync(long id)
        {
           var result = await _studentService.DeleteAsync(id);
            if (result is null) return NotFound();

            return Ok(result);
        }

    }
}

