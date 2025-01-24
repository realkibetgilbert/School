using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using School.API.Data;
using School.API.Dto.Hostel;
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

        public HostelController(IHostelService hostelService, IMapper mapper)
        {
           
            _hostelService = hostelService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] HostelToCreateDto hostelToCreateDto)
        {
            //var hostel = new Hostel
            //{
            //    Name = hostelToCreateDto.Name,
            //    Description = hostelToCreateDto.Description,
            //    CreatedOn = DateTime.Now,
            //    CreatedBy = "system",
            //};

            var hostels = _mapper.Map<Hostel>(hostelToCreateDto);
            return Ok(await _hostelService.CreateAsync(hostels));
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
