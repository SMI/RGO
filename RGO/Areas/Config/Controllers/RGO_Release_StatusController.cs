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
    public class RGO_Release_StatusController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;


        public RGO_Release_StatusController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            List<RGO_Release_Status> objRGO_Release_StatusList = _unitOfWork.RGO_Release_Status.GetAll().ToList();
            return View(objRGO_Release_StatusList);
        }


        public IActionResult Upsert(int? id)
        {


            if (id == null || id == 0)
            {
                //Insert
                return View(new RGO_Release_Status());
            }
            else
            {
                //Update
                var rgo_release_Status = _unitOfWork.RGO_Release_Status.FirstOrDefault(m => m.Id == id);
                if (rgo_release_Status == null)
                {
                    return NotFound();
                }
                return View(rgo_release_Status);

            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(RGO_Release_Status rgo_release_status)
        {

            string ActionType = "";

            if (ModelState.IsValid)
            {
                if (rgo_release_status.Id == 0)
                {
                    _unitOfWork.RGO_Release_Status.Add(rgo_release_status);
                    ActionType = "Create";
                }
                else
                {
                    _unitOfWork.RGO_Release_Status.Update(rgo_release_status);
                    ActionType = "Update";
                }

                _unitOfWork.Save();

                if (ActionType == "Create")
                {
                    TempData["success"] = "RGO Release Status created successfully";
                }
                else
                {
                    TempData["success"] = "RGO Release Status updated successfully";
                }


                return RedirectToAction(nameof(Index));
            } else 
            {
                return View(rgo_release_status); 
            }

        }

        #region API CALLS

        [HttpGet]
        public IActionResult GetAll()
        {
            List<RGO_Release_Status> objRGO_Release_StatusList = _unitOfWork.RGO_Release_Status.GetAll().ToList();
            return Json(new { data = objRGO_Release_StatusList });
        }


        [HttpDelete]
        public IActionResult Delete(int? id)
        {

            var rgo_release_StatusToBeDeleted = _unitOfWork.RGO_Release_Status.FirstOrDefault(u => u.Id == id);
            if (rgo_release_StatusToBeDeleted == null)
            {
                return Json(new { success = false, message = "Error while deleting RGO Release Status" });
            }

            _unitOfWork.RGO_Release_Status.Remove(rgo_release_StatusToBeDeleted);

            try
            {
                _unitOfWork.Save();

            }
            catch (DbUpdateException ex)
            {
                return Json(new { success = false, message = "This RGO Release Status cannot be deleted as there are records " +
                    $" that reference it.  If you want to delete this RGO Release Status, please change this"
                });
            }
            return Json(new { success = true, message = "RGO Release Status Deleted Successfully" });

        }
        #endregion
    }
}
