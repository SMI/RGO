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
    public class RGO_DatasetController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;


        public RGO_DatasetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            List<RGO_Dataset> objRGO_DatasetList = _unitOfWork.RGO_Dataset.GetAll().ToList();
            return View(objRGO_DatasetList);
        }

        public IActionResult Upsert(int? id)
        {

            RGO_DatasetVM rgo_DatasetVM = new()
            {

                RGO_Dataset_TemplateList = _unitOfWork.RGO_Dataset_Template.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                }),

                RGO_ReIdentificationConfigurationList = _unitOfWork.RGO_ReIdentificationConfiguration.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                }),
                RGO_Release_StatusList = _unitOfWork.RGO_Release_Status.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                }),
                RGO_Dataset = new RGO_Dataset()
            };
            if (id == null || id == 0)
            {
                //Insert
                return View(rgo_DatasetVM);
            }
            else
            {
                //Update
                rgo_DatasetVM.RGO_Dataset = _unitOfWork.RGO_Dataset.FirstOrDefault(m => m.Id == id, includeProperties: "RGO_Dataset_Template,RGO_ReIdentificationConfiguration,RGO_Release_Status");
                return View(rgo_DatasetVM);

            }

        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(RGO_Dataset rgo_Dataset)
        {

            string ActionType = "";

            if (ModelState.IsValid)
            {
                if (rgo_Dataset.Id == 0)
                {
                    _unitOfWork.RGO_Dataset.Add(rgo_Dataset);
                    ActionType = "Create";
                }
                else
                {
                    _unitOfWork.RGO_Dataset.Update(rgo_Dataset);
                    ActionType = "Update";
                }

                _unitOfWork.Save();

                if (ActionType == "Create")
                {
                    TempData["success"] = "rgo_Dataset created successfully";
                }
                else
                {
                    TempData["success"] = "rgo_Dataset updated successfully";
                }


                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(rgo_Dataset);
            }

        }

        #region API CALLS


        [HttpGet]
        public IActionResult GetAll()
        {
            List<RGO_Dataset> objRGO_DatasetList = _unitOfWork.RGO_Dataset.GetAll(includeProperties: "RGO_Dataset_Template,RGO_ReIdentificationConfiguration,RGO_Release_Status").ToList();
            return Json(new { data = objRGO_DatasetList });
        }

        [HttpDelete]
        public IActionResult Delete(int? id)
        {

            var rgo_datasetToBeDeleted = _unitOfWork.RGO_Dataset.FirstOrDefault(u => u.Id == id);
            if (rgo_datasetToBeDeleted == null)
            {
                return Json(new { success = false, message = "Error while deleting RGO_Dataset" });
            }

            _unitOfWork.RGO_Dataset.Remove(rgo_datasetToBeDeleted);

            try
            {
                _unitOfWork.Save();

            }
            catch (DbUpdateException)
            {
                return Json(new
                {
                    success = false,
                    message = "This RGO_Dataset cannot be deleted as an unexpected " +
                    $" exception was thrown"
                });
            }
            return Json(new { success = true, message = "RGO_Dataset deleted Successfully" });

        }

        #endregion

    }
}
