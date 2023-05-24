
using Book.DataAccess.Data;
using Book.DataAccess.Repository.IRepository;
using Book.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BookWormWeb.Areas.Admin.Controllers
{
    [Area("Admin")]


    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            List<Category> objCategoryList = _unitOfWork.CategoryRepo.GetAll().ToList();
            return View(objCategoryList);
        }
        //GET
        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        public IActionResult Create(Category obj)
        {
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("Name", "Display Order cannot exactly match the name");
            }
            if (ModelState.IsValid)
            {
                _unitOfWork.CategoryRepo.Add(obj);
                _unitOfWork.Save();
                TempData["success"] = "Category created successfully";
                return RedirectToAction("Index");
            }
            return View();
        }
        //GET
        public IActionResult Edit(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Category categoryFromDb = _unitOfWork.CategoryRepo.Get(i => i.Id == id);
            if (categoryFromDb == null)
            {
                return NotFound();
            }

            return View(categoryFromDb);
        }
        //POST
        [HttpPost]
        public IActionResult Edit(Category obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.CategoryRepo.Update(obj);
                _unitOfWork.Save();
                TempData["success"] = "Category updated successfully";
                return RedirectToAction("Index");
            }
            return View();
        }
        //GET
        public IActionResult Delete(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Category categoryFromDb = _unitOfWork.CategoryRepo.Get(i => i.Id == id);
            if (categoryFromDb == null)
            {
                return NotFound();
            }

            return View(categoryFromDb);
        }
        //POST
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            Category? obj = _unitOfWork.CategoryRepo.Get(i => i.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            _unitOfWork.CategoryRepo.Remove(obj);
            _unitOfWork.Save();
            TempData["success"] = "Category deleted successfully";
            return RedirectToAction("Index");
        }

    }

}
