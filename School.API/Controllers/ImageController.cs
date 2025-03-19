using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School.API.Interfaces;
using School.MODEL;

namespace School.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        private readonly IImageRepository _imageRepository;

        public ImageController(IImageRepository imageRepository)
        {
            _imageRepository = imageRepository;
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        [Route("UploadImage")]
        public async Task<IActionResult> UploadImage(
    [FromForm] IFormFile file,
    [FromForm] string fileName,
    [FromForm] string title)
        {
            if (ModelState.IsValid)
            {
                var blogImage = new Image
                {
                    FileExtension = Path.GetExtension(file.FileName).ToLower(),
                    FileName = fileName,
                    Title = title,
                    DateCreated = DateTime.Now,
                };

                await _imageRepository.Upload(file, blogImage);


                return Ok(blogImage);
            }
            return BadRequest(ModelState);
        }
    }
}
