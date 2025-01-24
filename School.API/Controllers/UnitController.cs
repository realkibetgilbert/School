using AutoMapper;
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
        private readonly IMapper _mapper;

        public UnitController(SchoolDbContext schooDbContext, IUnitService unitService, IMapper mapper)
        {
            this.schooDbContext = schooDbContext;
            _unitService = unitService;
            _mapper = mapper;
        }

        //https://localhost.com/api/unit/create
        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] UnitToCreateDto unitToCreateDto)
        { 
            var unit = _mapper.Map<Unit>(unitToCreateDto);
            return Ok(await _unitService.CreateAsync(unit));
        }

        [HttpGet] 
        public async Task<IActionResult> GetAsync()
        {
            List<Unit> units = await _unitService.GetAllAsync();
            return Ok(_mapper.Map<List<UnitToDisplayDto>>(units));           
        }

        [HttpGet]
        [Route("{id:long}")]
        public async Task<IActionResult> GetAsyncById(long id)
        {
           var unit= await _unitService.GetByIdAsync(id);                     
            return Ok(_mapper.Map<UnitToDisplayDto>(unit));
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
