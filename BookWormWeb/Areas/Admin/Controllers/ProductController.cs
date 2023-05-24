using Book.DataAccess.Repository.IRepository;
using Book.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookWormWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            List<Product> objProductList = _unitOfWork.ProductRepo.GetAll().ToList();
            return View(objProductList);
        }
        //GET
        public IActionResult Create()
        {
            return View();
        }
        //POST
        [HttpPost]
        public IActionResult Create(Product obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.ProductRepo.Add(obj);
                _unitOfWork.Save();
                TempData["success"] = "Product created successfully";
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
            Product productFromDb = _unitOfWork.ProductRepo.Get(i => i.Id == id);
            if (productFromDb == null)
            {
                return NotFound();
            }

            return View(productFromDb);
        }
        //POST
        [HttpPost]
        public IActionResult Edit(Product obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.ProductRepo.Update(obj);
                _unitOfWork.Save();
                TempData["success"] = "Product updated successfully";
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
            Product productFromDb = _unitOfWork.ProductRepo.Get(i => i.Id == id);
            if (productFromDb == null)
            {
                return NotFound();
            }

            return View(productFromDb);
        }
        //POST
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            Product? obj = _unitOfWork.ProductRepo.Get(i => i.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            _unitOfWork.ProductRepo.Remove(obj);
            _unitOfWork.Save();
            TempData["success"] = "Product deleted successfully";
            return RedirectToAction("Index");
        }

    }
}
