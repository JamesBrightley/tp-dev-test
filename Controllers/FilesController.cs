using DevTest.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DevTest.Controllers
{
    [Route("api/files")]
    public class FilesController : Controller
    { 
        private readonly IFileUploadService uploadService;
        public FilesController(IFileUploadService uploadService)
        {
            this.uploadService = uploadService;
        }

        [HttpPost]
        public async Task<IActionResult> UploadFileToBlobDirectory(IFormFile file)
        {
           throw new NotImplementedException();
        }
    }
}
