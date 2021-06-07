using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CRUD_with_ASP.NET.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CRUD_with_ASP.NET.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AppDbContext _db;

        public ProductsController(AppDbContext db)
        {
            _db = db;
        }
        // GET: /products
        public IActionResult Index()
        {
            var Products = _db.Products.ToList();
            ViewData["Products"] = Products;
            return View();
        }

        // GET: /products/id
        public IActionResult Details(int? id)
        {
            var Product = _db.Products.ToList().Find(product => product.Id == id);
            if(id == null || Product == null)
            {
                return View("_NotFound");
            }
            ViewData["Product"] = Product;
            return View();

        }
    }
}
