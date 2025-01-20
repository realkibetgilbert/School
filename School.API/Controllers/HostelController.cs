using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using School.API.Data;
using School.API.Dto.Hostel;
using School.MODEL;

namespace School.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HostelController : ControllerBase
    {
        private readonly SchoolDbContext _schoolDbContext;

        public HostelController(SchoolDbContext schoolDbContext)
        {
            _schoolDbContext = schoolDbContext;
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
            await _schoolDbContext.Hostels.AddAsync(hostel);
            await _schoolDbContext.SaveChangesAsync();
            return Ok(hostel);
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await _schoolDbContext.Hostels.ToListAsync());
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


    }
}
