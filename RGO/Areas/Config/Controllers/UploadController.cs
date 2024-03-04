using Microsoft.AspNetCore.Mvc;
using RGO.DataAccess.Repository;
using RGO.DataAccess.Repository.IRepository;
using RGO.Models;
using RGO.Models.Models;
using System.Diagnostics;

namespace RGO.Areas.Config.Controllers
{
    [Area("Config")]
    public class UploadController : Controller
    {
        private IUnitOfWork _unitOfWork;
        public UploadController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Upload()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upload(int? id) {
            IFormFile csvToUpload;
            try
            {
               csvToUpload = Request.Form.Files.First();
            }
            catch (Exception)
            {
                TempData["error"] = "No CSV file selected";
                return View();
            }
            var stream = csvToUpload.OpenReadStream();
            string fileName = Path.GetTempPath() + csvToUpload.FileName;


            try
            {
                using (FileStream fs = System.IO.File.OpenWrite(fileName))
                {
                    stream.CopyTo(fs);
                }
                var uploader = new CSV_Uploader(fileName,_unitOfWork);
                if (!uploader.PreCheck())
                {
                    TempData["error"] = "Something went wrong with the Upload. Please try again.";
                    return View();
                }
                uploader.ExecuteUpload();
            }
            finally
            {
                System.IO.File.Delete(fileName);
            }
            TempData["success"] = "CSV Successfully Uploaded";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
