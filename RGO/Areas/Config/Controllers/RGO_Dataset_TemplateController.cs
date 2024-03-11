using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.CodeAnalysis.Elfie.Serialization;
using Microsoft.EntityFrameworkCore;
using NPOI.HPSF;
using RGO.DataAccess.Data;
using RGO.DataAccess.Repository;
using RGO.DataAccess.Repository.IRepository;
using RGO.Models;
using RGO.Models.Models;
using RGO.Models.ViewModels;
using RGO.Utility;

namespace RGO.Areas.Config.Controllers
{
    [Area("Config")]
    public class RGO_Dataset_TemplateController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;


        public RGO_Dataset_TemplateController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            List<RGO_Dataset_Template> objRGO_Dataset_TemplateList = _unitOfWork.RGO_Dataset_Template.GetAll(includeProperties: "RGOutput").ToList();
            return View(objRGO_Dataset_TemplateList);
        }

        public IActionResult Upsert(int? id)
        {

            RGO_Dataset_TemplateVM rgo_dataset_templateVM = new()
            {
                RGOutputList = _unitOfWork.RGOutput.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                }),
                RGO_Dataset_Template = new RGO_Dataset_Template()

            };


            if (id == null || id == 0)
            {
                //Insert
                return View(rgo_dataset_templateVM);
            }
            else
            {
                //Update

                rgo_dataset_templateVM.RGO_Dataset_Template = _unitOfWork.RGO_Dataset_Template.FirstOrDefault(m => m.Id == id, includeProperties: "RGOutput");
                return View(rgo_dataset_templateVM);

            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(RGO_Dataset_TemplateVM rgo_dataset_templateVM)
        {

            string ActionType = "";

            if (ModelState.IsValid)
            {
                if (rgo_dataset_templateVM.RGO_Dataset_Template.Id == 0)
                {
                    _unitOfWork.RGO_Dataset_Template.Add(rgo_dataset_templateVM.RGO_Dataset_Template);
                    ActionType = "Create";
                }
                else
                {
                    _unitOfWork.RGO_Dataset_Template.Update(rgo_dataset_templateVM.RGO_Dataset_Template);
                    ActionType = "Update";
                }

                _unitOfWork.Save();

                if (ActionType == "Create")
                {
                    TempData["success"] = "RGO Dataset Template created successfully";
                }
                else
                {
                    TempData["success"] = "RGO Dataset Template updated successfully";
                }


                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(rgo_dataset_templateVM);
            }

        }

 
    #region API CALLS


    [HttpGet]
    public IActionResult GetAll()
    {
        List<RGO_Dataset_Template> objRGO_Dataset_TemplateList = _unitOfWork.RGO_Dataset_Template.GetAll(includeProperties: "RGOutput").ToList();
        return Json(new { data = objRGO_Dataset_TemplateList });
    }

    [HttpDelete]
    public IActionResult Delete(int? id)
    {

        var rgo_dataset_templateToBeDeleted = _unitOfWork.RGO_Dataset_Template.FirstOrDefault(u => u.Id == id);
        if (rgo_dataset_templateToBeDeleted == null)
        {
            return Json(new { success = false, message = "Error while deleting RGO_Dataset_Template" });
        }

        _unitOfWork.RGO_Dataset_Template.Remove(rgo_dataset_templateToBeDeleted);

        try
        {
            _unitOfWork.Save();

        }
        catch (DbUpdateException ex)
        {
            return Json(new
            {
                success = false,
                message = "This RGO_Dataset_Template cannot be deleted as there are RG Outputs " +
                $" that reference it.  If you want to delete this RGO_Dataset_Template, please change the RGOutputs referenced by it first"
            });
        }
        return Json(new { success = true, message = "RGO_Dataset_Template deleted Successfully" });

    }

        ///config/rgo_dataset_template/download/${data}

        [HttpGet]
        public async Task<IActionResult> Download(int? id)
        {
            var rgo_dataset_template = _unitOfWork.RGO_Dataset_Template.FirstOrDefault(u => u.Id == id);
            var generator = new CSVGenerator(rgo_dataset_template, _unitOfWork);
            var file = generator.CreateCSV();
            var fileName = System.IO.Path.GetFileName(file);
            var content = await System.IO.File.ReadAllBytesAsync(file);
            new FileExtensionContentTypeProvider()
                .TryGetContentType(fileName, out string contentType);
            return File(content, contentType, fileName);
        }

        #endregion

    }


}
