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
    public class EvidenceController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;


        public EvidenceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public IActionResult Index()
        {
            List<Evidence> objEvidenceList = _unitOfWork.Evidence.GetAll(includeProperties: "Evidence_Type").ToList();
            return View(objEvidenceList);
        }

        public IActionResult Upsert(int? id)
        {

            EvidenceVM evidenceVM = new()
            {

                Evidence_TypeList = _unitOfWork.Evidence_Type.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                }),
                Evidence = new Evidence()
            };
            if (id == null || id == 0)
            {
                //Insert
                return View(evidenceVM);
            }
            else
            {
                //Update
                evidenceVM.Evidence = _unitOfWork.Evidence.FirstOrDefault(m => m.Id == id,includeProperties: "Evidence_Type");
                return View(evidenceVM);

            }

        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(EvidenceVM evidenceVM)
        {

            string ActionType = "";

            if (ModelState.IsValid)
            {
                if (evidenceVM.Evidence.Id == 0)
                {
                    _unitOfWork.Evidence.Add(evidenceVM.Evidence);
                    ActionType = "Create";
                }
                else
                {
                    _unitOfWork.Evidence.Update(evidenceVM.Evidence);
                    ActionType = "Update";
                }

                _unitOfWork.Save();

                if (ActionType == "Create")
                {
                    TempData["success"] = "Evidence created successfully";
                }
                else
                {
                    TempData["success"] = "Evidence updated successfully";
                }


                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(evidenceVM);
            }

        }


        #region API CALLS


        [HttpGet]
        public IActionResult GetAll()
        {
            List<Evidence> objEvidenceList = _unitOfWork.Evidence.GetAll(includeProperties: "Evidence_Type").ToList();
            return Json(new { data = objEvidenceList });
        }

        [HttpDelete]
        public IActionResult Delete(int? id)
        {

            var evidenceToBeDeleted = _unitOfWork.Evidence.FirstOrDefault(u => u.Id == id);
            if (evidenceToBeDeleted == null)
            {
                return Json(new { success = false, message = "Error while deleting Evidence" });
            }

            _unitOfWork.Evidence.Remove(evidenceToBeDeleted);

            try
            {
                _unitOfWork.Save();

            }
            catch (DbUpdateException ex)
            {
                return Json(new
                {
                    success = false,
                    message = "This Evidence cannot be deleted as there are RG Outputs " +
                    $" that reference it.  If you want to delete this Evidence, please the references from these RGOs first"
                });
            }
            return Json(new { success = true, message = "Evidence deleted Successfully" });

        }

        #endregion


    }
}