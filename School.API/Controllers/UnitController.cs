using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using School.API.Data;
using School.API.Dto.Units;
using School.API.Interfaces.unitsImplementations;
using School.MODEL;

namespace School.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitController : ControllerBase
    {
        private readonly SchoolDbContext schooDbContext;
        private readonly IUnitService _unitService;

        public UnitController(SchoolDbContext schooDbContext, IUnitService unitService)
        {
            this.schooDbContext = schooDbContext;
            _unitService = unitService;
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

            return Ok(await _unitService.CreateAsync(unit));
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await _unitService.GetAllAsync());
        }

        [HttpGet]
        [Route("{id:long}")]
        public async Task<IActionResult> GetAsyncById(long id)
        {
            return Ok(await _unitService.GetByIdAsync(id));
        }

        [HttpPut]
        [Route("{id:long}")]
        public async Task<IActionResult> UpdateStudentAsync(long id, UpdateUnitDto updateUnitDto)
        {
            var result = await _unitService.UpdateUnitAsync(id, updateUnitDto);
            if (result is null) return NotFound();

            return Ok(result);
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
