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
    public class RGO_Record_PersonController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;


        public RGO_Record_PersonController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Upsert(int? id)
        {


            //if (id == null || id == 0)
            //{
                //Insert
                return View(new RGO_Record_Person());
            //}
            //else
            //{
            //    //Update
            //    var group_Type = _unitOfWork.Group_Type.FirstOrDefault(m => m.Id == id);
            //    if (group_Type == null)
            //    {
            //        return NotFound();
            //    }
            //    return View(group_Type);

            //}

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(RGO_Record_Person rgo_record_person)
        {

            string ActionType = "";

            if (ModelState.IsValid)
            {
                if (rgo_record_person.Id == 0)
                {
                    _unitOfWork.RGO_Record_Person.Add(rgo_record_person);
                    ActionType = "Create";
                }
                //else
                //{
                //    _unitOfWork.Group_Type.Update(group_type);
                //    ActionType = "Update";
                //}

                _unitOfWork.Save();

                if (ActionType == "Create")
                {
                    TempData["success"] = "RGO_Record_Person created successfully";
                }
                //else
                //{
                //    TempData["success"] = "RGO_Record_Person updated successfully";
                //}


                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(rgo_record_person);
            }

        }

    }
}
