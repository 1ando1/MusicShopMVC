using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PagedList;

namespace Music_Shop.Controllers
{
    public class GuitarsController : Controller
    {
        private readonly MusicShopDbContext context;

        public GuitarsController(MusicShopDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index(string sortOrder, string searchString, string currentFilter, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParam = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.TypeSortParam = String.IsNullOrEmpty(sortOrder) ? "type_desc" : "";
            ViewBag.PriceSortParam = String.IsNullOrEmpty(sortOrder) ? "price_desc" : "";

            if (searchString != null) page = 1;
            else searchString = currentFilter;

            ViewBag.CurrentFilter = searchString;

            //var guitars = context.Guitars.ToList();
            var guitars = from g in context.Guitars select g;

            if (!String.IsNullOrEmpty(searchString))
            {
                guitars = guitars.Where(g => g.Name.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    guitars = guitars.OrderByDescending(g => g.Name);
                    break;
                case "type_desc":
                    guitars = guitars.OrderByDescending(g => g.Type);
                    break;
                case "price_desc":
                    guitars = guitars.OrderByDescending(g => g.Price);
                    break;
                default:
                    guitars = guitars.OrderBy(g => g.Id);
                    break;
            }

            int pageSize = 3;
            int pageNumber = (page ?? 1);
            return View(guitars.ToPagedList(pageNumber, pageSize));
        }
        public IActionResult Details(int id)
        {
            Models.Guitar? guitar = context.Guitars.Include(g => g.ExtraProduct).FirstOrDefault(g => g.Id == id);

            if (guitar == null) return NotFound();

            ViewBag.ReturnUrl = Request.Headers["Referer"].ToString();

            return View(guitar);
        }
        public IActionResult Add()
        {
            var extraProdsList = context.ExtraProducts.ToList();
            ViewBag.ExtraProdsList = new SelectList(extraProdsList, nameof(Data.Models.ExtraProduct.Id), nameof(Data.Models.ExtraProduct.Name));

            return View();
        }
        [HttpPost]
        public IActionResult Add(Models.Guitar guitar)
        {
            if (!ModelState.IsValid)
            {
                var extraProdsList = context.ExtraProducts.ToList();
                ViewBag.ExtraProdsList = new SelectList(extraProdsList, nameof(Data.Models.ExtraProduct.Id), nameof(Data.Models.ExtraProduct.Name));

                return View(guitar);
            }
            context.Guitars.Add(guitar);
            context.SaveChanges();

            TempData["alertMessage"] = "Product was successfully added!";

            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int id)
        {
            Models.Guitar guitar = context.Guitars.Find(id);
            if (guitar != null)
            {
                context.Guitars.Remove(guitar);
                context.SaveChanges();
            }

            TempData["alertMessage"] = "Product was successfully deleted!";
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Edit(int id)
        {
            Models.Guitar? guitar = context.Guitars.Find(id);

            var extraProdsList = context.ExtraProducts.ToList();
            ViewBag.ExtraProdsList = new SelectList(extraProdsList, nameof(Data.Models.ExtraProduct.Id), nameof(Data.Models.ExtraProduct.Name));

            if (guitar == null) return NotFound();

            return View(guitar);
        }
        [HttpPost]
        public IActionResult Edit(Models.Guitar guitar)
        {
            if (!ModelState.IsValid)
            {
                var extraProdsList = context.ExtraProducts.ToList();
                ViewBag.ExtraProdsList = new SelectList(extraProdsList, nameof(Data.Models.ExtraProduct.Id), nameof(Data.Models.ExtraProduct.Name));

                return View();
            }

            context.Entry(guitar).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();

            TempData["alertMessage"] = "Product was successfully edited!";

            return RedirectToAction(nameof(Index));
        }
    }
}
