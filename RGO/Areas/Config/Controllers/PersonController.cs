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

        public IActionResult Index()
        {
            List<Person> objPersonList = _unitOfWork.Person.GetAll().ToList();
            return View(objPersonList);
        }


        public IActionResult Upsert(int? id)
        {


            if (id == null || id == 0)
            {
                //Insert
                return View(new Person());
            }
            else
            {
                //Update
                var person = _unitOfWork.Person.FirstOrDefault(m => m.Id == id);
                if (person == null)
                {
                    return NotFound();
                }
                return View(person);

            }

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
                else
                {
                    _unitOfWork.Person.Update(person);
                    ActionType = "Update";
                }

                _unitOfWork.Save();

                if (ActionType == "Create")
                {
                    TempData["success"] = "Person created successfully";
                }
                else
                {
                    TempData["success"] = "Person updated successfully";
                }


                return RedirectToAction(nameof(Index));
            } else 
            {
                return View(person); 
            }

        }

        #region API CALLS

        [HttpGet]
        public IActionResult GetAll()
        {
            List<Person> objPersonList = _unitOfWork.Person.GetAll().ToList();
            return Json(new { data = objPersonList });
        }


        [HttpDelete]
        public IActionResult Delete(int? id)
        {

            var personToBeDeleted = _unitOfWork.Person.FirstOrDefault(u => u.Id == id);
            if (personToBeDeleted == null)
            {
                return Json(new { success = false, message = "Error while deleting Person" });
            }

            _unitOfWork.Person.Remove(personToBeDeleted);

            try
            {
                _unitOfWork.Save();

            }
            catch (DbUpdateException ex)
            {
                return Json(new { success = false, message = "This Person cannot be deleted as there are Research outputs " +
                    $" that reference it.  If you want to delete this Person, please change the Ground Truthers of these Research Outputs first"
                });
            }
            return Json(new { success = true, message = "Person Deleted Successfully" });

        }
        #endregion
    }
}
