using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using RGO.DataAccess.Data;
using RGO.DataAccess.Repository;
using RGO.DataAccess.Repository.IRepository;
using RGO.Models;
using RGO.Models.Models;
using RGO.Models.ViewModels;

namespace RGO.Areas.Config.Controllers
{
    [Area("Config")]
    public class Evidence_TypeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;


        public Evidence_TypeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            List<Evidence_Type> objEvidence_TypeList = _unitOfWork.Evidence_Type.GetAll().ToList();
            return View(objEvidence_TypeList);
        }


        public IActionResult Upsert(int? id)
        {


            if (id == null || id == 0)
            {
                //Insert
                return View(new Evidence_Type());
            }
            else
            {
                //Update
                var evidence_Type = _unitOfWork.Evidence_Type.FirstOrDefault(m => m.Id == id);
                if (evidence_Type == null)
                {
                    return NotFound();
                }
                return View(evidence_Type);

            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Evidence_Type evidence_type)
        {

            string ActionType = "";

            if (ModelState.IsValid)
            {
                if (evidence_type.Id == 0)
                {
                    _unitOfWork.Evidence_Type.Add(evidence_type);
                    ActionType = "Create";
                }
                else
                {
                    _unitOfWork.Evidence_Type.Update(evidence_type);
                    ActionType = "Update";
                }

                _unitOfWork.Save();

                if (ActionType == "Create")
                {
                    TempData["success"] = "Evidence Type created successfully";
                }
                else
                {
                    TempData["success"] = "Evidence Type updated successfully";
                }


                return RedirectToAction(nameof(Index));
            } else 
            {
                return View(evidence_type); 
            }

        }

        #region API CALLS

        [HttpGet]
        public IActionResult GetAll()
        {
            List<Evidence_Type> objEvidenceTypeList = _unitOfWork.Evidence_Type.GetAll().ToList();
            return Json(new { data = objEvidenceTypeList });
        }


        [HttpDelete]
        public IActionResult Delete(int? id)
        {

            var evidenceTypeToBeDeleted = _unitOfWork.Evidence_Type.FirstOrDefault(u => u.Id == id);
            if (evidenceTypeToBeDeleted == null)
            {
                return Json(new { success = false, message = "Error while deleting Evidence Type" });
            }

            _unitOfWork.Evidence_Type.Remove(evidenceTypeToBeDeleted);

            try
            {
                _unitOfWork.Save();

            }
            catch (DbUpdateException)
            {
                return Json(new { success = false, message = "This Evidence Type cannot be deleted as there are Evidences " +
                    $" that reference it.  If you want to delete this Evidence Type, please change the Evidence Type of these Evidences first"
                });
            }
            return Json(new { success = true, message = "Evidence Type Deleted Successfully" });

        }
        #endregion
    }
}
