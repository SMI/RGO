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
    public class GroupController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;


        public GroupController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public IActionResult Index()
        {
            List<Group> objGroupList = _unitOfWork.Group.GetAll(includeProperties: "Group_Type").ToList();
            return View(objGroupList);
        }

        public IActionResult Upsert(int? id)
        {

            GroupVM groupVM = new()
            {

                Group_TypeList = _unitOfWork.Group_Type.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                }),
                Group = new Group()
            };
            if (id == null || id == 0)
            {
                //Insert
                return View(groupVM);
            }
            else
            {
                //Update
                groupVM.Group = _unitOfWork.Group.FirstOrDefault(m => m.Id == id,includeProperties:"Group_Type");
                return View(groupVM);

            }

        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(GroupVM groupVM)
        {

            string ActionType = "";

            if (ModelState.IsValid)
            {
                if (groupVM.Group.Id == 0)
                {
                    //groupVM.Group.Created_Date = DateTime.UtcNow;
                    _unitOfWork.Group.Add(groupVM.Group);
                    ActionType = "Create";
                }
                else
                {
                    //groupVM.Group.Updated_Date = DateTime.UtcNow;
                    _unitOfWork.Group.Update(groupVM.Group);
                    ActionType = "Update";
                }

                _unitOfWork.Save();

                if (ActionType == "Create")
                {
                    TempData["success"] = "Group created successfully";
                }
                else
                {
                    TempData["success"] = "Group updated successfully";
                }


                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(groupVM);
            }

        }


        #region API CALLS


        [HttpGet]
        public IActionResult GetAll()
        {
            List<Group> objGroupList = _unitOfWork.Group.GetAll(includeProperties: "Group_Type").ToList();
            return Json(new { data = objGroupList });
        }

        [HttpDelete]
        public IActionResult Delete(int? id)
        {

            var groupToBeDeleted = _unitOfWork.Group.FirstOrDefault(u => u.Id == id);
            if (groupToBeDeleted == null)
            {
                return Json(new { success = false, message = "Error while deleting Group" });
            }

            _unitOfWork.Group.Remove(groupToBeDeleted);

            try
            {
                _unitOfWork.Save();

            }
            catch (DbUpdateException)
            {
                return Json(new
                {
                    success = false,
                    message = "This Group cannot be deleted as there are RG Outputs " +
                    $" that reference it.  If you want to delete this Group, please change the Group referenced by these RGOs first"
                });
            }
            return Json(new { success = true, message = "Group deleted Successfully" });

        }

        #endregion


    }
}