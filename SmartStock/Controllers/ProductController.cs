using Microsoft.AspNetCore.Mvc;
using SmartStock.Data;
using SmartStock.Models;

namespace SmartStock.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(string search, string category)
        {
            var products = _context.Products.AsQueryable();

            if (!string.IsNullOrEmpty(search))
                products = products.Where(p => p.Name.Contains(search));

            if (!string.IsNullOrEmpty(category))
                products = products.Where(p => p.Category == category);

            ViewBag.Categories = _context.Products.Select(p => p.Category).Distinct().ToList();

            return View(products.ToList());
        }
        public IActionResult Details(int id)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
       
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Add(product);
                TempData["success"] = "Product Created Successfully";
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product);
        }

        public IActionResult Edit(int id)
        {
            var product = _context.Products.Find(id);
            if (product == null) return NotFound();
            return View(product);
        }
        [HttpPost]
       
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Update(product);
                TempData["success"] = "Product Updated Successfully";
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product);
        }
        #region API CALLS

        [HttpGet]
        public IActionResult GetAll()
        {
            var productList = _context.Products.ToList();
            return Json(new { data = productList });
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var product = _context.Products.Find(id);
            if (product == null) return Json(new { success = false, message = "Error while deleting" });

            _context.Products.Remove(product);
            _context.SaveChanges();
            return Json(new { success = true, message = "Delete successful" });
        }

        #endregion

    }
}
