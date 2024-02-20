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
    public class PersonController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;


        public PersonController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Upsert(int? id)
        {


            //if (id == null || id == 0)
            //{
                //Insert
                return View(new Person());
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
        public IActionResult Upsert(Person person)
        {

            string ActionType = "";

            if (ModelState.IsValid)
            {
                if (person.Id == 0)
                {
                    _unitOfWork.Person.Add(person);
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
                    TempData["success"] = "Person created successfully";
                }
                //else
                //{
                //    TempData["success"] = "rgo_Dataset_Template updated successfully";
                //}


                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(person);
            }

        }

    }
}
