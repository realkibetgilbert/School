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
            //var unit = new Unit
            //{
            //    UnitName = unitToCreateDto.UnitName,
            //    UnitCode = unitToCreateDto.UnitCode,
            //    Status = unitToCreateDto.Status,
            //    CreatedOn = DateTime.Now,
            //    CreatedBy = "system",
            //};          

            //d=>s

            var unit = _mapper.Map<Unit>(unitToCreateDto);
            return Ok(await _unitService.CreateAsync(unit));
        }

        [HttpGet] 
        public async Task<IActionResult> GetAsync()
        {
            List<Unit> units = await _unitService.GetAllAsync();
            //List<UnitToDisplayDto> listToDisplay = units.Select(unit => new UnitToDisplayDto
            //{
            //    Id = unit.Id,
            //    UnitName = unit.UnitName,
            //    UnitCode = unit.UnitCode,
            //    Status = unit.Status
            //}).ToList();
         var listToDisplay1 = _mapper.Map<List<UnitToDisplayDto>>(units);
            return Ok(listToDisplay1);
            


        }

        [HttpGet]
        [Route("{id:long}")]
        public async Task<IActionResult> GetAsyncById(long id)
        {
           var unit= await _unitService.GetByIdAsync(id);
            var unitToDisplay1 = new UnitToDisplayDto
            {
                Id = unit.Id,
                UnitName = unit.UnitName,
                UnitCode = unit.UnitCode,
                Status = unit.Status
            };

            var unitToDisplay2= _mapper.Map<UnitToDisplayDto>(unit);
            return Ok(unitToDisplay1);
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
