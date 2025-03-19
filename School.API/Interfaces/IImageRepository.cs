using School.MODEL;

namespace School.API.Interfaces
{
    public interface IImageRepository
    {
        Task<Image> Upload(IFormFile formFile, Image Image);
    }
}
