﻿using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
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
        private readonly IHostelService _hostelService;
        private readonly IMapper _mapper;
        private readonly ILogger<HostelController> _logger;
        private readonly IValidator<HostelToCreateDto> _validator;

        public HostelController(IHostelService hostelService,
            IMapper mapper, ILogger<HostelController> logger, IValidator<HostelToCreateDto> validator
            )
        {
            _hostelService = hostelService;
            _mapper = mapper;
            _logger = logger;
            _validator = validator;
        }

        [HttpPost]
        [Authorize(Roles ="Admin")]
        public async Task<IActionResult> CreateAsync([FromBody] HostelToCreateDto hostelToCreateDto)
        {
            try
            {
                _logger.LogInformation($"Registration of hostel, {hostelToCreateDto.Name}, strated");
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
                
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest("Something went wrong");
                
            }
            var hostel = _mapper.Map<Hostel>(hostelToCreateDto);
            await _hostelService.CreateAsync(hostel);
            _logger.LogInformation($"Registration of hostel, {hostelToCreateDto.Name}, ended");
            return Ok(_mapper.Map<HostelToDisplayDto>(hostel));
        }

        [HttpGet]
        [Route("{id:long}")]
        [Authorize(Roles = "Student")]
        public async Task<IActionResult> GetAsync([FromRoute] long id)
        {
            return Ok(await _hostelService.GetByIdAsync(id));
        }

        [HttpGet]
        [Authorize(Roles = "Student")]
        public async Task<IActionResult> GetAsync([FromQuery] int? pageNumber, int? pageSize)
        {
            var hostels = await _hostelService.GetAllAsync(pageNumber,pageSize);
            var hostelToDisplay = _mapper.Map<List<HostelToDisplayDto>>(hostels);
            return Ok(hostelToDisplay);
        }

        [HttpPut]
        [Route("{id:long}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdateHostelAsync(long id, UpdateHostelDto updateHostelDto)
        {
            var result = await _hostelService.UpdateHostelAsync(id, updateHostelDto);
            if (result is null) return NotFound();

            return Ok(_mapper.Map<HostelToDisplayDto>(result));

        }

        [HttpDelete]
        [Authorize(Roles = "Admin")]
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
