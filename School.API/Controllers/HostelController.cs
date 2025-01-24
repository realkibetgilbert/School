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

            var hostels = _mapper.Map<Hostel>(hostelToCreateDto);
            return Ok(await _hostelService.CreateAsync(hostels));
        }

        [HttpGet]
        [Route("{id:long}")]
        public async Task<IActionResult> GetAsync([FromRoute] long id)
        {
            var hostel = await _hostelService.GetByIdAsync(id);
            return Ok(_mapper.Map<HostelToDisplayDto>(hostel));
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            List<Hostel> hostel = await _hostelService.GetAllAsync();
            return Ok(_mapper.Map<List<HostelToDisplayDto>>(hostel));
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
