using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;
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
    public class RGOutputController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;


        public RGOutputController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public IActionResult Index()
        {
            List<RGOutput> objRGOutputList = _unitOfWork.RGOutput.GetAll(includeProperties: "RGO_Type,Group").ToList();

            return View(objRGOutputList);
        }


        public IActionResult Upsert(int? id)
        {

            RGOutputVM rgoutputVM = new()
            {

                RGO_TypeList = _unitOfWork.RGO_Type.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                }),
                GroupList = _unitOfWork.Group.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                }),
                RGOutput = new RGOutput()
            };
            if (id == null || id == 0)
            {
                //Insert
                return View(rgoutputVM);
            }
            else
            {
                //Update
                rgoutputVM.RGOutput = _unitOfWork.RGOutput.FirstOrDefault(m => m.Id == id, includeProperties: "RGO_Type,Group");
                return View(rgoutputVM);


            }

        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(RGOutputVM rgoutputVM)
        {

            string ActionType = "";

            if (ModelState.IsValid)
            {
                if (rgoutputVM.RGOutput.Id == 0)
                {
                    _unitOfWork.RGOutput.Add(rgoutputVM.RGOutput);
                    ActionType = "Create";
                }
                else
                {
                    _unitOfWork.RGOutput.Update(rgoutputVM.RGOutput);
                    ActionType = "Update";
                }

                _unitOfWork.Save();

                if (ActionType == "Create")
                {
                    TempData["success"] = "RG Output created successfully";
                }
                else
                {
                    TempData["success"] = "RG Output updated successfully";
                }


                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(rgoutputVM);
            }

        }


        #region API CALLS


        [HttpGet]
        public IActionResult GetAll()
        {
            List<RGOutput> objRGOutputList = _unitOfWork.RGOutput.GetAll(includeProperties: "RGO_Type,Group").ToList();
            Console.Write(objRGOutputList);
            return Json(new { data = objRGOutputList });
        }

        [HttpDelete]
        public IActionResult Delete(int? id)
        {

            var rgoutputToBeDeleted = _unitOfWork.RGOutput.FirstOrDefault(u => u.Id == id);
            if (rgoutputToBeDeleted == null)
            {
                return Json(new { success = false, message = "Error while deleting RG Output" });
            }

            _unitOfWork.RGOutput.Remove(rgoutputToBeDeleted);

            //try
            //{
                _unitOfWork.Save();

            //}
            //catch (DbUpdateException ex)
            //{
            //    return Json(new
            //    {
            //        success = false,
            //        message = "This RG Output cannot be deleted as there are RG Ouptuts " +
            //        $" that reference it.  If you want to delete this Group, please change the Group referenced by these RGOs first"
            //    });
            //}
            return Json(new { success = true, message = "RG Output deleted Successfully" });

        }

        #endregion


    }
}