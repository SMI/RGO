using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using RGO.DataAccess.Repository.IRepository;
using RGO.Models;
using RGO.Models.Models;
using RGO.Utility;

namespace RGO.Areas.Config.Controllers
{
    [Area("Config")]
    public class RGO_ReIdentificationConfigurationController : Controller
    {

        private readonly IUnitOfWork _unitOfWork;

        public RGO_ReIdentificationConfigurationController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create(){
            return View(new RGO_ReIdentificationConfiguration());
        }




        [HttpGet]
        public IActionResult GetAll()
        {
            List<RGO_ReIdentificationConfiguration> objRGOTypeList = _unitOfWork.RGO_ReIdentificationConfiguration.GetAll().ToList();
            return Json(new { data = objRGOTypeList });
        }


        [HttpPost("/config/RGO_ReIdentificationConfiguration/reidentify")]
        public IActionResult ReIdentify(int datasetId, int reidentificationId)
        {
            RGO_Dataset dataset = _unitOfWork.RGO_Dataset.GetAll().Where(ds => ds.Id == datasetId).First();
            RGO_ReIdentificationConfiguration config = _unitOfWork.RGO_ReIdentificationConfiguration.GetAll().Where(re => re.Id == reidentificationId).First();
            var reidentifier = new ReIdentify(dataset, config, _unitOfWork);
            reidentifier.Execute();
            TempData["success"] = "Successfully ReIdentified the Data";
            //will want do do a fail message also
            return Json(TempData);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(RGO_ReIdentificationConfiguration redentificationConfiguration )
        {

            string ActionType = "";

            if (ModelState.IsValid)
            {
            
                    _unitOfWork.RGO_ReIdentificationConfiguration.Add(redentificationConfiguration);
                    ActionType = "Create";
             
                _unitOfWork.Save();

                if (ActionType == "Create")
                {
                    TempData["success"] = "ReIdentification Configuration created successfully";
                }
                else
                {
                    TempData["success"] = "ReIdentification Configuration updated successfully";
                }


                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(redentificationConfiguration);
            }

        }

        [HttpDelete]
        public IActionResult Delete(int? id)
        {

            var rgo_reidentificationconfigToBeDeleted = _unitOfWork.RGO_ReIdentificationConfiguration.FirstOrDefault(u => u.Id == id);
            if (rgo_reidentificationconfigToBeDeleted == null)
            {
                return Json(new { success = false, message = "Error while deleting RGO ReIdentification Configuration" });
            }

            _unitOfWork.RGO_ReIdentificationConfiguration.Remove(rgo_reidentificationconfigToBeDeleted);

            try
            {
                _unitOfWork.Save();

            }
            catch (DbUpdateException ex)
            {
                return Json(new
                {
                    success = false,
                    message = "This RGO ReIdentification Configuration cannot be deleted as there are RGO Datasets " +
                    $" that reference it.  If you want to delete this RGO ReIdentification Configuration, please change this"
                });
            }
            return Json(new { success = true, message = "RGO ReIdentification Configuration Deleted Successfully" });

        }
    }
}