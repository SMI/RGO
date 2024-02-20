using Microsoft.AspNetCore.Mvc;
using RGO.Models;
using RGO.Models.Models;
using System.Diagnostics;

namespace RGO.Areas.Config.Controllers
{
    [Area("Config")]
    public class UploadController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public UploadController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Upload()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upload(int? id) {
            var csvToUpload = Request.Form.Files.First();
            var stream = csvToUpload.OpenReadStream();
            string fileName = Path.GetTempPath() + csvToUpload.FileName;


            try
            {
                using (FileStream fs = System.IO.File.OpenWrite(fileName))
                {
                    stream.CopyTo(fs);
                }
                // Do whatever you want with the file here
                var uploader = new CSV_Uploader(fileName);
                if (!uploader.PreCheck())
                {
                    //todo handle this better
                    throw new Exception("Something went wrong with the precheck");
                }
                uploader.ExecuteUpload();
            }
            finally
            {
                System.IO.File.Delete(fileName);
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
