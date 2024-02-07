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
    public class Group_TypeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;


        public Group_TypeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            List<Group_Type> objGroup_TypeList = _unitOfWork.Group_Type.GetAll().ToList();
            return View(objGroup_TypeList);
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var group_type = _unitOfWork.Group_Type
                .FirstOrDefault(m => m.Id == id);
            if (group_type == null)
            {
                return NotFound();
            }

            return View(group_type);
        }

        public IActionResult Upsert(int? id)
        {


            if (id == null || id == 0)
            {
                //Insert
                return View(new Group_Type());
            }
            else
            {
                //Update
                var group_Type = _unitOfWork.Group_Type.FirstOrDefault(m => m.Id == id);
                if (group_Type == null)
                {
                    return NotFound();
                }
                return View(group_Type);

            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Group_Type group_type)
        {

            string ActionType = "";

            if (ModelState.IsValid)
            {
                if (group_type.Id == 0)
                {
                    _unitOfWork.Group_Type.Add(group_type);
                    ActionType = "Create";
                }
                else
                {
                    _unitOfWork.Group_Type.Update(group_type);
                    ActionType = "Update";
                }

                _unitOfWork.Save();

                if (ActionType == "Create")
                {
                    TempData["success"] = "Group Type created successfully";
                }
                else
                {
                    TempData["success"] = "Group Type updated successfully";
                }


                return RedirectToAction(nameof(Index));
            } else 
            {
                return View(group_type); 
            }

        }

        #region API CALLS

        [HttpGet]
        public IActionResult GetAll()
        {
            List<Group_Type> objGroupTypeList = _unitOfWork.Group_Type.GetAll().ToList();
            return Json(new { data = objGroupTypeList });
        }


        [HttpDelete]
        public IActionResult Delete(int? id)
        {

            var groupTypeToBeDeleted = _unitOfWork.Group_Type.FirstOrDefault(u => u.Id == id);
            if (groupTypeToBeDeleted == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

            _unitOfWork.Group_Type.Remove(groupTypeToBeDeleted);
            _unitOfWork.Save();

            return Json(new { success = true, message = "Delete Successful" });
        }

        #endregion
    }
}
