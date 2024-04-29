using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RGO.DataAccess.Data;
using RGO.DataAccess.Repository;
using RGO.DataAccess.Repository.IRepository;
using RGO.Models;
using RGO.Models.Models;
using RGO.Models.ViewModels;

namespace RGO.Areas.Config.Controllers
{
    [Area("Config")]
    public class RGO_EvidenceController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;


        public RGO_EvidenceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public IActionResult Index()
        {
            List<RGO_Evidence> objRGO_EvidenceList = _unitOfWork.RGO_Evidence.GetAll(includeProperties: "Evidence,RGOutput").ToList();
            return View(objRGO_EvidenceList);
        }

        public IActionResult Upsert(int? id)
        {

            RGO_EvidenceVM rgo_evidenceVM = new()
            {

                EvidenceList = _unitOfWork.Evidence.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                }),
                RGOutputList = _unitOfWork.RGOutput.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                }),
                RGO_Evidence = new RGO_Evidence()
            };
            if (id == null || id == 0)
            {
                //Insert
                return View(rgo_evidenceVM);
            }
            else
            {
                //Update
                rgo_evidenceVM.RGO_Evidence = _unitOfWork.RGO_Evidence.FirstOrDefault(m => m.Id == id,includeProperties: "Evidence,RGOutput");
                return View(rgo_evidenceVM);

            }

        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(RGO_EvidenceVM rgo_evidenceVM)
        {

            string ActionType = "";

            if (ModelState.IsValid)
            {
                if (rgo_evidenceVM.RGO_Evidence.Id == 0)
                {
                    _unitOfWork.RGO_Evidence.Add(rgo_evidenceVM.RGO_Evidence);
                    ActionType = "Create";
                }
                else
                {
                    _unitOfWork.RGO_Evidence.Update(rgo_evidenceVM.RGO_Evidence);
                    ActionType = "Update";
                }

                _unitOfWork.Save();

                if (ActionType == "Create")
                {
                    TempData["success"] = "RGO_Evidence created successfully";
                }
                else
                {
                    TempData["success"] = "RGO_Evidence updated successfully";
                }


                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(rgo_evidenceVM);
            }

        }


        #region API CALLS


        [HttpGet]
        public IActionResult GetAll()
        {
            List<RGO_Evidence> objRGO_EvidenceList = _unitOfWork.RGO_Evidence.GetAll(includeProperties: "Evidence,RGOutput").ToList();
            return Json(new { data = objRGO_EvidenceList });
        }

        [HttpDelete]
        public IActionResult Delete(int? id)
        {

            var rgo_evidenceToBeDeleted = _unitOfWork.RGO_Evidence.FirstOrDefault(u => u.Id == id);
            if (rgo_evidenceToBeDeleted == null)
            {
                return Json(new { success = false, message = "Error while deleting RGO_Evidence" });
            }

            _unitOfWork.RGO_Evidence.Remove(rgo_evidenceToBeDeleted);

            try
            {
                _unitOfWork.Save();

            }
            catch (DbUpdateException)
            {
                return Json(new
                {
                    success = false,
                    message = "This RGO_Evidence cannot be deleted as there are RG Outputs and/or Evidence Records " +
                    $" that reference it.  If you want to delete this Evidence, please change this"
                });
            }
            return Json(new { success = true, message = "RGO_Evidence deleted Successfully" });

        }

        #endregion


    }
}