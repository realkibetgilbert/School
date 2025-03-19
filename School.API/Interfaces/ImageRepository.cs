using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using School.API.Data;
using School.MODEL;

namespace School.API.Interfaces
{
    public class ImageRepository : IImageRepository
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly SchoolDbContext _context;

        public ImageRepository(IWebHostEnvironment webHostEnvironment, IHttpContextAccessor httpContextAccessor, SchoolDbContext context)
        {
            _webHostEnvironment = webHostEnvironment;
            _httpContextAccessor = httpContextAccessor;
            _context = context;
        }

        public async Task<Image> Upload(IFormFile formFile, Image Image)
        {     
            //UPLOAD IMAGE TO API FOLDER......

            var localPath = Path.Combine(_webHostEnvironment.ContentRootPath, "Images", $"{Image.FileName}{Image.FileExtension}");

            using var stream = new FileStream(localPath, FileMode.Create);

            await formFile.CopyToAsync(stream);

            //update the database......


            // https://codepulse/images/filaname.jpeg
            var httpRequest = _httpContextAccessor.HttpContext.Request;
            var urlPath = $"{httpRequest.Scheme}://{httpRequest.Host}{httpRequest.PathBase}/Images/{Image.FileName}{Image.FileExtension}";
            Image.Url = urlPath;
            await _context.Images.AddAsync(Image);
            await _context.SaveChangesAsync();
            return Image;
        }
    }
}
