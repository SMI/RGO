using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RGO.DataAccess.Data;
using RGO.DataAccess.Repository.IRepository;
using RGO.Models;

namespace RGO.Areas.Config.Controllers
{
    [Area("Config")]
    public class Group_TypeController : Controller
    {

        private readonly IUnitOfWork _unitOfWork;


        public Group_TypeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            List<Group_Type> objList = _unitOfWork.Group_Type.GetAll().ToList();
            return View(objList);
           //return View(_unitOfWork.Group_Type.ToList());
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var group_Type = _unitOfWork.Group_Type
                .FirstOrDefault(m => m.Id == id);
            if (group_Type == null)
            {
                return NotFound();
            }

            return View(group_Type);
        }

        // GET: Group_Type/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Group_Type/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Name,Created_By,Created_Date,Updated_By,Updated_Date,Notes")] Group_Type group_Type)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Group_Type.Add(group_Type);
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(group_Type);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var group_Type = _unitOfWork.Group_Type.FirstOrDefault(m => m.Id == id); 
            if (group_Type == null)
            {
                return NotFound();
            }
            return View(group_Type);
        }

        // POST: Group_Type/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Name,Created_By,Created_Date,Updated_By,Updated_Date,Notes")] Group_Type group_Type)
        {
            if (id != group_Type.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _unitOfWork.Group_Type.Update(group_Type);
                    _unitOfWork.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    /*if (!Group_TypeExists(group_Type.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }*/
                }
                return RedirectToAction(nameof(Index));
            }
            return View(group_Type);
        }


        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var group_Type = _unitOfWork.Group_Type
                .FirstOrDefault(m => m.Id == id);
            if (group_Type == null)
            {
                return NotFound();
            }

            return View(group_Type);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var group_Type = _unitOfWork.Group_Type.FirstOrDefault(m => m.Id == id); 
            if (group_Type != null)
            {
                _unitOfWork.Group_Type.Remove(group_Type);
            }

            _unitOfWork.Save();
            return RedirectToAction(nameof(Index));
        }

      /*  private bool Group_TypeExists(int id)
        {
            return _unitOfWork.Group_Type.Any(e => e.Id == id);
        }*/
    }
}
