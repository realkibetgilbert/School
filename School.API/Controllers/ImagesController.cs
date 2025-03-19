using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace School.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {


        [HttpPost]
        [Consumes("multipart/form-data")]
        [Route("upload")]
        public async Task<IActionResult> UploadImage([FromForm] IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return BadRequest("Invalid file.");
            }

            using (var client = new HttpClient())
            {
                using (var content = new MultipartFormDataContent())
                {
                    var fileStream = file.OpenReadStream();
                    var streamContent = new StreamContent(fileStream);
                    streamContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(file.ContentType);

                    content.Add(streamContent, "file", file.FileName);

                    string externalApiUrl = "https://localhost:7002/api/FileHandler/upload"; // Replace with actual URL
                    var response = await client.PostAsync(externalApiUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        var responseBody = await response.Content.ReadAsStringAsync();
                        return Ok(new { ImageName = responseBody });
                    }
                    else
                    {
                        return StatusCode((int)response.StatusCode, "Error uploading file.");
                    }
                }
            }
        }
    }
}
