using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
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
    public class GroupController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;


        public GroupController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: Config/Group
        public IActionResult Index()
        {
            List<Group> objList = _unitOfWork.Group.GetAll(includeProperties:"Group_Type").ToList();
            return View(objList);
        }

        // GET: Config/Group/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var group = _unitOfWork.Group
                .FirstOrDefault(m => m.Id == id);
            if (group == null)
            {
                return NotFound();
            }

            return View(group);
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
                groupVM.Group = _unitOfWork.Group.FirstOrDefault(m => m.Id == id);
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
                    _unitOfWork.Group.Add(groupVM.Group);
                    ActionType = "Create";
    }
                else
                {
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
                // if there are any errors on the page, you need to explicitly repopulate the dropdown
                groupVM.Group_TypeList = _unitOfWork.Group_Type.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                });
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
                return Json(new { success = false, message = "Error while deleting" });
            }

            _unitOfWork.Group.Remove(groupToBeDeleted);
            _unitOfWork.Save();

            return Json(new { success = true, message = "Delete Successful" });
        }

        #endregion
    }
}
