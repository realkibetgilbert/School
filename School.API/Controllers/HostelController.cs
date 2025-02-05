using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using School.API.Data;
using School.API.Dto.Hostel;
using School.API.Dto.Students;
using School.API.Interfaces.implementations;
using School.MODEL;

namespace School.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HostelController : ControllerBase
    {
        private readonly SchoolDbContext _schoolDbContext;
        private readonly IHostelService _hostelService;
        private readonly IMapper _mapper;
        private readonly ILogger<HostelController> _logger;
        private readonly IValidator<HostelToCreateDto> _validator;

        public HostelController(SchoolDbContext schoolDbContext, IHostelService hostelService,
            IMapper mapper, ILogger<HostelController> logger, IValidator<HostelToCreateDto> validator
            )
        {
            _schoolDbContext = schoolDbContext;
            _hostelService = hostelService;
            _mapper = mapper;
            _logger = logger;
            _validator = validator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] HostelToCreateDto hostelToCreateDto)
        {
            var valid = await _validator.ValidateAsync(hostelToCreateDto);
            if (!valid.IsValid)
            {
                var errors = valid.Errors.Select(e => new
                {
                    Field = e.PropertyName,
                    ErrorMessage = e.ErrorMessage
                });

                return BadRequest(new
                {
                    Message = "Validation failed",
                    Errors = errors
                });
            }
            var hostel = _mapper.Map<Hostel>(hostelToCreateDto);
            await _hostelService.CreateAsync(hostel);
            var hostelToDisplay = _mapper.Map<HostelToDisplayDto>(hostel);
            return Ok(hostelToDisplay);
        }

        [HttpGet]
        [Route("{id:long}")]
        public async Task<IActionResult> GetAsync([FromRoute] long id)
        {
            return Ok(await _hostelService.GetByIdAsync(id));
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await _hostelService.GetAllAsync());
        }

        [HttpPut]
        [Route("{id:long}")]
        public async Task<IActionResult> UpdateHostelAsync(long id, UpdateHostelDto updateHostelDto)
        {
            var result = await _hostelService.UpdateHostelAsync(id, updateHostelDto);
            if (result is null) return NotFound();

            return Ok(result);

        }

        [HttpDelete]
        [Route("{id:long}")]
        public async Task<IActionResult> DeleteAsync([FromRoute] long id)
        {
            var result = await _hostelService.DeleteAsync(id);
            if (result == null)
            { return NotFound(); };

            return Ok(result);
        }


    }
}
