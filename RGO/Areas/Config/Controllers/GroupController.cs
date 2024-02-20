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

        // GET: Config/Group
        public IActionResult Index()
        {
            List<Group> objList = _unitOfWork.Group.GetAll(includeProperties: "Group_Type").ToList();
            return View(objList);
        }

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
            if (ModelState.IsValid)
            {
                _unitOfWork.Group.Add(groupVM.Group);
                _unitOfWork.Save();
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

 
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var group = _unitOfWork.Group.FirstOrDefault(m => m.Id == id);
            if (group == null)
            {
                return NotFound();
            }

            return View(group);
        }








        #region API CALLS


        [HttpGet]
        public IActionResult GetAll()
        {
            List<Group> objGroupList = _unitOfWork.Group.GetAll(includeProperties: "Group_Type").ToList();
            return Json(new { data = objGroupList });
        }

        [HttpDelete]
        public IActionResult DeleteConfirmed(int? id)
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
            catch (DbUpdateException ex)
            {
                return Json(new
                {
                    success = false,
                    message = "This Group cannot be deleted as there are RG Ouptuts " +
                    $" that reference it.  If you want to delete this Group, please change the Group referenced by these RGOs first"
                });
            }
            return Json(new { success = true, message = "Group deleted Successfully" });

        }


  /*      [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            //var @group = await _unitOfWork.Group.FindAsync(id);
            var group = _unitOfWork.Group.FirstOrDefault(m => m.Id == id);
            if (group != null)
            {
                _unitOfWork.Group.Remove(group);
            }

            _unitOfWork.Save();

            return RedirectToAction(nameof(Index));
        }*/


        #endregion


    }
}