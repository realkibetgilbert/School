using AutoMapper;
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

        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;

        public StudentController(IStudentService studentService, IMapper mapper)
        {

            _studentService = studentService;
            _mapper = mapper;
        }
        //https://localhost.com/api/Student/Create
        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] StudentToCreateDto studentToCreateDto)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); };
            //dto for us to save in db we neeed to map to table.....model
            var student = _mapper.Map<Student>(studentToCreateDto);
            return Ok(await _studentService.CreateAsync(student));
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            List<Student> students =await _studentService.GetAllAsync();
            return  Ok(_mapper.Map<List<StudentToDisplayDto>>(students));

        }

        [HttpGet]
        [Route("{id:long}")]
        public async Task<IActionResult> GetAsyncById(long id)
        {
            return Ok(await _studentService.GetByIdAsync(id));
        }

        [HttpPut]
        [Route("{id:long}")]
        public async Task<IActionResult> PutAsyncById(long id, UpdateStudentDto updateStudentDto)
        {
            var student = await _studentService.UpdateAsync(id, updateStudentDto);
            if (student is null) return NotFound();

            return Ok(student);

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

