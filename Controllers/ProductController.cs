using CarlosAPP.Data;
using CarlosAPP.Models;
using Microsoft.AspNetCore.Mvc;


namespace CarlosAPP.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ProductController(ApplicationDbContext db)
        {
            _db = db;
        }
        //GET
        public IActionResult Index()
        {
            IEnumerable<Product> products = _db.Products;
            return View(products);
        }
        //GET
        public IActionResult Create() 
        {
            return View();
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product product)
        {
            if (!ModelState.IsValid) 
            {
                TempData["error"] = "Product didn't create";
            }
            if (ModelState.IsValid)
            {
                _db.Products.Add(product);
                _db.SaveChanges();
                TempData["success"] = "Product was Created Successfully";
                return RedirectToAction("Index");
            }
            return View(product);
        }
        //GET
        public IActionResult Edit(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var product = _db.Products.Find(id);
            if (product == null) { return NotFound(); }
            return View(product);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Product product)
        {
            if (!ModelState.IsValid)
            {
                TempData["error"] = "Product didn't update";
            }
            if (ModelState.IsValid)             
            {
                _db.Products.Update(product);
                _db.SaveChanges();
                TempData["success"] = "Product was Updated Successfully";
                return RedirectToAction("Index");
            }
            return View(product);
        }
    }
}
