using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using School.API.Data;
using School.API.Dto.Units;
using School.MODEL;

namespace School.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitController : ControllerBase
    {
        private readonly SchoolDbContext schooDbContext;

        public UnitController(SchoolDbContext schooDbContext)
        {
            this.schooDbContext = schooDbContext;
        }

        //https://localhost.com/api/unit/create
        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] UnitToCreateDto unitToCreateDto)
        {
            var unit = new Unit
            {
                UnitName = unitToCreateDto.UnitName,
                UnitCode = unitToCreateDto.UnitCode,
                Status = unitToCreateDto.Status,
                CreatedOn = DateTime.Now,
                CreatedBy = "system",
            };

            await schooDbContext.Units.AddAsync(unit);
            await schooDbContext.SaveChangesAsync();

            return Ok(unit);
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await schooDbContext.Units.ToListAsync());
        }

        [HttpGet]
        [Route("{id:long}")]
        public async Task<IActionResult> GetAsyncById(long id)
        {
            var unit = await schooDbContext.Units.FindAsync(id);

            if (unit == null )
            {
                return NotFound();
            }
            return Ok(unit);
        }

        [HttpPut]
        [Route("{id:long}")]
        public async Task<IActionResult> UpdateStudentAsync(long id, UpdateUnitDto updateUnitDto)
        {
            var unit = await schooDbContext.Units.FindAsync(id);
            if (unit is null)
            {
                return NotFound();
            }
            unit.UnitName = updateUnitDto.UnitName;
            unit.UnitCode = updateUnitDto.UnitCode;
            unit.Status = updateUnitDto.Status;
            unit.CreatedOn = DateTime.Now;
            unit.CreatedBy = "system";

            await schooDbContext.SaveChangesAsync();
            return Ok(unit);
        }

        [HttpDelete]
        [Route("{id:long}")]
        public async Task<IActionResult> DeleteUnitAsync([FromRoute] long id)
        {
            var unit = await schooDbContext.Units.FindAsync(id);
            if (unit == null)
            {
                return NotFound();
            }

             schooDbContext.Units.Remove(unit);
            await schooDbContext.SaveChangesAsync();

            return Ok();
        }
      
    }
}
