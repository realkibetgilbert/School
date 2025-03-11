using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using School.API.Data;
using School.API.Dto.Students;
using School.API.Dto.Units;
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
        private readonly IValidator<StudentToCreateDto> _validator;
        private readonly ILogger<StudentController> _logger;

        public StudentController(IStudentService studentService, IMapper mapper, IValidator<StudentToCreateDto> validator, ILogger<StudentController> logger)
        {

            _studentService = studentService;
            _mapper = mapper;
            _validator = validator;
            _logger = logger;
        }
        //https://localhost.com/api/Student/Create
        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] StudentToCreateDto studentToCreateDto)
        {
            try
            {
                _logger.LogInformation($"Registration of student of reg no {studentToCreateDto.RegistrationNumber} strated");
                IsHostelFull();
                var valid = await _validator.ValidateAsync(studentToCreateDto);
                // Check if validation failed
                if (!valid.IsValid)
                {
                    // Extract errors and format them as a list of messages
                    var errors = valid.Errors.Select(e => new
                    {
                        Field = e.PropertyName,
                        ErrorMessage = e.ErrorMessage
                    });

                    // Return a 400 Bad Request response with the errorsmmm
                    return BadRequest(new
                    {
                        Message = "Validation failed",
                        Errors = errors
                    });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest("something went wrong");


            }
            if (!ModelState.IsValid) { return BadRequest(ModelState); };
            //dto for us to save in db we neeed to map to table.....model
            var student = _mapper.Map<Student>(studentToCreateDto);
            await _studentService.CreateAsync(student);
            _logger.LogInformation($"Registration of student of reg no {studentToCreateDto.RegistrationNumber} ended");
            return Ok(_mapper.Map<StudentToDisplayDto>(student));
        }

        private void IsHostelFull()
        {
            var hostelSize = 60;
            if (hostelSize >= 60)
            {

                throw new Exception("Hostel is full the size of hall six is 60");

            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            List<Student> students = await _studentService.GetAllAsync();
            return Ok(_mapper.Map<List<StudentToDisplayDto>>(students));

        }

        [HttpGet]
        [Route("{id:long}")]
        public async Task<IActionResult> GetAsyncById(long id)
        {
            var student = await _studentService.GetByIdAsync(id);
            return Ok(_mapper.Map<StudentToDisplayDto>(student));
        }

        [HttpPut]
        [Route("{id:long}")]
        public async Task<IActionResult> PutAsyncById(long id, UpdateStudentDto updateStudentDto)
        {
            var student = await _studentService.UpdateAsync(id, updateStudentDto);
            if (student is null) return NotFound();

            return Ok(_mapper.Map<StudentToDisplayDto>(student));

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

