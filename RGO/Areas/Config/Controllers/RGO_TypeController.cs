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
    public class RGO_TypeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;


        public RGO_TypeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            List<RGO_Type> objRGO_TypeList = _unitOfWork.RGO_Type.GetAll().ToList();
            return View(objRGO_TypeList);
        }


        public IActionResult Upsert(int? id)
        {


            if (id == null || id == 0)
            {
                //Insert
                return View(new RGO_Type());
            }
            else
            {
                //Update
                var rgo_Type = _unitOfWork.RGO_Type.FirstOrDefault(m => m.Id == id);
                if (rgo_Type == null)
                {
                    return NotFound();
                }
                return View(rgo_Type);

            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(RGO_Type rgo_type)
        {

            string ActionType = "";

            if (ModelState.IsValid)
            {
                if (rgo_type.Id == 0)
                {
                    _unitOfWork.RGO_Type.Add(rgo_type);
                    ActionType = "Create";
                }
                else
                {
                    _unitOfWork.RGO_Type.Update(rgo_type);
                    ActionType = "Update";
                }

                _unitOfWork.Save();

                if (ActionType == "Create")
                {
                    TempData["success"] = "RGO Type created successfully";
                }
                else
                {
                    TempData["success"] = "RGO Type updated successfully";
                }


                return RedirectToAction(nameof(Index));
            } else 
            {
                return View(rgo_type); 
            }

        }

        #region API CALLS

        [HttpGet]
        public IActionResult GetAll()
        {
            List<RGO_Type> objRGOTypeList = _unitOfWork.RGO_Type.GetAll().ToList();
            return Json(new { data = objRGOTypeList });
        }


        [HttpDelete]
        public IActionResult Delete(int? id)
        {

            var rgoTypeToBeDeleted = _unitOfWork.RGO_Type.FirstOrDefault(u => u.Id == id);
            if (rgoTypeToBeDeleted == null)
            {
                return Json(new { success = false, message = "Error while deleting RGO Type" });
            }

            _unitOfWork.RGO_Type.Remove(rgoTypeToBeDeleted);

            try
            {
                _unitOfWork.Save();

            }
            catch (DbUpdateException)
            {
                return Json(new { success = false, message = "This RGO Type cannot be deleted as there are RG Outputs" +
                    $" that reference it.  If you want to delete this RGO Type, please change the RGO Type of these RG Outputs first"});
            }
            return Json(new { success = true, message = "RGO Type Deleted Successfully" });

        }
        #endregion
    }
}
