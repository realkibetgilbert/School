using FileHandler.Data;
using FileHandler.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FileHandler.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileHandlerController : ControllerBase
    {
        private readonly IWebHostEnvironment _environment;
        private readonly ApplicationDbContext _context;

        public FileHandlerController(IWebHostEnvironment environment, ApplicationDbContext context)
        {
            _environment = environment;
            _context = context;
        }

        [HttpPost("upload")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> UploadImage([FromForm] IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return BadRequest(new { Message = "Invalid file." });
            }

            try
            {
                // 📌 1. Generate unique file name
                string fileExtension = Path.GetExtension(file.FileName).ToLower();
                string uniqueFileName = $"{Guid.NewGuid()}{fileExtension}";

                // 📌 2. Define path to save the image
                string uploadFolder = Path.Combine(_environment.WebRootPath, "uploads");
                if (!Directory.Exists(uploadFolder))
                {
                    Directory.CreateDirectory(uploadFolder);
                }

                string filePath = Path.Combine(uploadFolder, uniqueFileName);

                // 📌 3. Save file to the folder
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                // 📌 4. Save to Database
                var imageRecord = new FileDetail
                {
                    FileName = uniqueFileName,
                    FileExtension = fileExtension,
                    DateCreated = DateTime.UtcNow
                };

                _context.FileDetails.Add(imageRecord);
                await _context.SaveChangesAsync();

                // 📌 5. Return Image Name
                return Ok(new { ImageName = uniqueFileName });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "Internal Server Error", Error = ex.Message });
            }
        }
    }
}
