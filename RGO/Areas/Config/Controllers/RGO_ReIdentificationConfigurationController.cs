using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Migrations;
using RGO.DataAccess.Repository.IRepository;
using RGO.Models;
using RGO.Models.Models;

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
            List<RGO_ReIdentificationConfiguration> objRGOTypeList = _unitOfWork.Reidentification.GetAll().ToList();
            return Json(new { data = objRGOTypeList });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(RGO_ReIdentificationConfiguration redentificationConfiguration )
        {

            string ActionType = "";

            if (ModelState.IsValid)
            {
            
                    _unitOfWork.Reidentification.Add(redentificationConfiguration);
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
    }
}