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
        private readonly SchoolDbContext _schoolDbContext;
        private readonly IHostelService _hostelService;

        public HostelController(SchoolDbContext schoolDbContext, IHostelService hostelService)
        {
            _schoolDbContext = schoolDbContext;
            _hostelService = hostelService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] HostelToCreateDto hostelToCreateDto)
        {
            var hostel = new Hostel
            {
                Name = hostelToCreateDto.Name,
                Description = hostelToCreateDto.Description,
                CreatedOn = DateTime.Now,
                CreatedBy = "system",
            };
            return Ok(await _hostelService.CreateAsync(hostel));
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
            var hostel = await _schoolDbContext.Hostels.FindAsync(id);

            if (hostel == null) return NotFound();

            hostel.Name = updateHostelDto.Name;
            hostel.Description = updateHostelDto.Description;
            hostel.CreatedOn = DateTime.Now;
            hostel.CreatedBy = "System";

            await _schoolDbContext.SaveChangesAsync();
            return Ok(hostel);

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
