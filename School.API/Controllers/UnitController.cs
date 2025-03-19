using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using School.API.Data;
using School.API.Dto.Students;
using School.API.Dto.Units;
using School.API.Interfaces.unitsImplementations;
using School.MODEL;

namespace School.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitController : ControllerBase
    {
        
        private readonly IUnitService _unitService;
        private readonly IMapper _mapper;
        private readonly IValidator<UnitToCreateDto> _validator;
        private readonly ILogger<UnitController> _logger;

        public UnitController(IUnitService unitService, IMapper mapper, IValidator<UnitToCreateDto> validator, ILogger<UnitController> logger)
        {
            
            _unitService = unitService;
            _mapper = mapper;
            _validator = validator;
            _logger = logger;
        }

        //https://localhost.com/api/unit/create
        [HttpPost]
        [Authorize(Roles ="Admin")]
        public async Task<IActionResult> CreateAsync([FromBody] UnitToCreateDto unitToCreateDto)
        {
            try
            {
                _logger.LogInformation($"Registration of unit {unitToCreateDto.UnitName} started");
                var valid = await _validator.ValidateAsync(unitToCreateDto);
                // Check if validation failed
                if (!valid.IsValid)
                {
                    // Extract errors and format them as a list of messages
                    var errors = valid.Errors.Select(e => new
                    {
                        Field = e.PropertyName,
                        ErrorMessage = e.ErrorMessage
                    });

                    // Return a 400 Bad Request response with the errors
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
            }

            var unit = _mapper.Map<Unit>(unitToCreateDto);
            await _unitService.CreateAsync(unit);
            _logger.LogInformation($"Registration of unit {unitToCreateDto.UnitName} ended");
            return Ok(_mapper.Map<UnitToDisplayDto>(unit));
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync([FromQuery] int? pageNumber, int? pageSize)
        {
            List<Unit> units = await _unitService.GetAllAsync(pageNumber, pageSize);
            return Ok(_mapper.Map<List<UnitToDisplayDto>>(units));
        }

        [HttpGet]
        [Route("{id:long}")]
        public async Task<IActionResult> GetAsyncById(long id)
        {
            var unit = await _unitService.GetByIdAsync(id);
            return Ok(_mapper.Map<UnitToDisplayDto>(unit));
        }

        [HttpPut]
        [HttpPut]
        [Route("{id:long}")]
        public async Task<IActionResult> UpdateStudentAsync(long id, UpdateUnitDto updateUnitDto)
        {
            var result = await _unitService.UpdateUnitAsync(id, updateUnitDto);
            if (result is null) return NotFound();

            return Ok(_mapper.Map<UnitToDisplayDto>(result));
        }

        [HttpDelete]
        [Route("{id:long}")]
        public async Task<IActionResult> DeleteUnitAsync([FromRoute] long id)
        {
            var result = await _unitService.DeleteAsync(id);
            if (result is null) return NotFound();

            return Ok(result);


        }

    }
}
