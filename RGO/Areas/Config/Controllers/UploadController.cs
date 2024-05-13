using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RGO.DataAccess.Repository.IRepository;
using RGO.Models;

namespace RGO.Areas.Config.Controllers;

[Area("Config")]
public class UploadController : Controller
{
    private readonly IUnitOfWork _unitOfWork;

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
    public IActionResult Upload(int? id)
    {
        IFormFile csvToUpload;
        int datasetTemplateId = 0;
        try
        {
            foreach (string key in Request.Form.Keys)
            {
                if (key.StartsWith("selected_dataset_template"))
                {
                    datasetTemplateId = Convert.ToInt32(Request.Form[key]);
                }

            }
        }
        catch (Exception)
        {
            TempData["error"] = "No Dataset Template selected";
            return View();
        }
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
        var fileName = Path.GetTempPath() + csvToUpload.FileName;


        try
        {
            using (var fs = System.IO.File.OpenWrite(fileName))
            {
                stream.CopyTo(fs);
            }

            var uploader = new CSV_Uploader(fileName, datasetTemplateId, _unitOfWork);
            if (!uploader.PreCheck())
            {
                TempData["error"] = "Something went wrong with the Upload (pre-check stage). Please try again.";
                return View();
            }

            if (!uploader.ExecuteUpload())
            {
                //set status to failed
                var foundDataset = _unitOfWork.RGO_Dataset.GetAll().Where(ds => ds.Dataset_Status == "Uploading")
                    .OrderByDescending(ds => ds.Id).First();
                if (foundDataset is not null)
                {
                    foundDataset.Dataset_Status = "Failed";
                    _unitOfWork.Save();
                }

                TempData["error"] =
                    "Something went wrong with the Upload. It's possible that the column headers in the input file don't match those in the templates.  Please check this, then try again.";
                return View();
            }
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