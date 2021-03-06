using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CRUD_with_ASP.NET.Data;
using CRUD_with_ASP.NET.Models;
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
            return View(Product);

        }

        //GET - /products/create
        public IActionResult Create()
        {
            return View();
        }

        //POST - /proudcts/create
        [HttpPost]
        public IActionResult Create([Bind("Id", "Name","Description","Price")]ProductModel product)
        {
            if (ModelState.IsValid) //check the state of model
            {
                _db.Products.Add(product);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product);
        }


        //GEt - /products/edit/id
        public IActionResult Edit(int? id)
        {
            var Product = _db.Products.ToList().Find(p => p.Id == id);
            if (id == null || Product == null)
            {
                return View("_NotFound");
            }
            ViewData["Product"] = Product;
            return View();
        }

        //POST - /products/edit/id
        [HttpPost]
        public IActionResult Edit([Bind("Id","Name", "Description", "Price")] ProductModel prod)
        {
            //var Product = _db.Products.ToList().Find(p => p.Id == id);
            //Product.Name = prod.Name;
            //Product.Description = prod.Description;
            //Product.Price = prod.Price;

            //_db.Products.Update(Product);
            //_db.SaveChanges();
            _db.Products.Update(prod);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

        // POST - /products/delete/id
        [HttpPost]
        public IActionResult Delete(int? id)
        {
            var Product = _db.Products.ToList().FirstOrDefault(p => p.Id == id);
            if (id == null || Product == null)
            {
                return View("_NotFound");
            }
            _db.Products.Remove(Product);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
