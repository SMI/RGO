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
    public class RGO_Column_TemplateController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;


        public RGO_Column_TemplateController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        //public IActionResult Index()
        //{
        //    List<RGO_Column_Template> objRGO_Column_TemplateList = _unitOfWork.RGO_Column_Template.GetAll(includeProperties: "RGO_Dataset_Template").ToList();
        //    return View(objRGO_Column_TemplateList);
        //}


        public IActionResult Index(int? parentId)
        {
            List<RGO_Column_Template> objRGO_Column_TemplateList;

            if (parentId == null | parentId == 0)
            {
                objRGO_Column_TemplateList = _unitOfWork.RGO_Column_Template.GetAll(includeProperties: "RGO_Dataset_Template").ToList();
                return View(objRGO_Column_TemplateList);
            }
            else
            {
                objRGO_Column_TemplateList = _unitOfWork.RGO_Column_Template.GetAll(r => r.RGO_Dataset_TemplateId == parentId, includeProperties: "RGO_Dataset_Template").ToList();

                return View(objRGO_Column_TemplateList);
            }

        }



        public IActionResult Upsert(int? id)
        {

            RGO_Column_TemplateVM rgo_column_templateVM = new()
            {
                RGO_Dataset_TemplateList = _unitOfWork.RGO_Dataset_Template.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                }),
                RGO_Column_Template = new RGO_Column_Template()

            };


            if (id == null || id == 0)
            {
                //Insert
                return View(rgo_column_templateVM);
            }
            else
            {
                //Update

                rgo_column_templateVM.RGO_Column_Template = _unitOfWork.RGO_Column_Template.FirstOrDefault(m => m.Id == id, includeProperties: "RGO_Dataset_Template");
                return View(rgo_column_templateVM);

            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(RGO_Column_TemplateVM rgo_column_templateVM)
        {

            string ActionType = "";

            if (ModelState.IsValid)
            {
                if (rgo_column_templateVM.RGO_Column_Template.Id == 0)
                {
                    _unitOfWork.RGO_Column_Template.Add(rgo_column_templateVM.RGO_Column_Template);
                    ActionType = "Create";
                }
                else
                {
                    _unitOfWork.RGO_Column_Template.Update(rgo_column_templateVM.RGO_Column_Template);
                    ActionType = "Update";
                }

                _unitOfWork.Save();

                if (ActionType == "Create")
                {
                    TempData["success"] = "RGO Column Template created successfully";
                }
                else
                {
                    TempData["success"] = "RGO Column Template updated successfully";
                }


                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(rgo_column_templateVM);
            }

        }


        #region API CALLS


        //[HttpGet]
        //public IActionResult GetAll()
        //{
        //    List<RGO_Column_Template> objRGO_Column_TemplateList = _unitOfWork.RGO_Column_Template.GetAll(includeProperties: "RGO_Dataset_Template").ToList();
        //    return Json(new { data = objRGO_Column_TemplateList });
        //}

        [HttpGet]
        public IActionResult GetAll()
        {
            List<RGO_Column_Template> objRGO_Column_TemplateList;
            objRGO_Column_TemplateList = _unitOfWork.RGO_Column_Template.GetAll(includeProperties: "RGO_Dataset_Template").ToList();
            return Json(new { data = objRGO_Column_TemplateList });
        }

        [HttpGet("/config/rgo_column_template/getall/{parentId}")]
        public IActionResult GetAll(int? parentId)
        {
            List<RGO_Column_Template> objRGO_Column_TemplateList;

            if (parentId == null | parentId == 0)
            {
                objRGO_Column_TemplateList = _unitOfWork.RGO_Column_Template.GetAll(includeProperties: "RGO_Dataset_Template").ToList();
                return Json(new { data = objRGO_Column_TemplateList });
            }
            else
            {
                objRGO_Column_TemplateList = _unitOfWork.RGO_Column_Template.GetAll(r => r.RGO_Dataset_TemplateId == parentId, includeProperties: "RGO_Dataset_Template").ToList();
                return Json(new { data = objRGO_Column_TemplateList });
            }

        }








        [HttpDelete]
        public IActionResult Delete(int? id)
        {

            var rgo_column_templateToBeDeleted = _unitOfWork.RGO_Column_Template.FirstOrDefault(u => u.Id == id);
            if (rgo_column_templateToBeDeleted == null)
            {
                return Json(new { success = false, message = "Error while deleting RGO_Column_Template" });
            }

            _unitOfWork.RGO_Column_Template.Remove(rgo_column_templateToBeDeleted);

            try
            {
                _unitOfWork.Save();

            }
            catch (DbUpdateException ex)
            {
                return Json(new
                {
                    success = false,
                    message = "This RGO_Column_Template cannot be deleted as there are RG_Column or RGO_Record_Person records " +
                    $" that reference it.  If you want to delete this RGO_Column_Template, please change this"
                });
            }
            return Json(new { success = true, message = "RGO_Column_Template deleted Successfully" });

        }

        #endregion

    }
}
