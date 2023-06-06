using Data;
using Microsoft.AspNetCore.Mvc;
using Music_Shop.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Music_Shop.Controllers
{
    public class CartController : Controller
    {
        private readonly MusicShopDbContext context;
        public CartController(MusicShopDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            List<int>? ids = HttpContext.Session.GetObject<List<int>>("cartKey");
            if (ids == null) ids = new List<int>();

            List<Models.Guitar?> guitars = ids.Select(id => context.Guitars.Find(id)).ToList();

            return View(guitars);
        }

        public IActionResult Add(int id)
        {
            if (context.Guitars.Find(id) == null) return NotFound();

            List<int>? ids = HttpContext.Session.GetObject<List<int>>("cartKey");

            if (ids == null) ids = new List<int>();

            ids.Add(id);

            HttpContext.Session.SetObject("cartKey", ids);

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Remove(int id)
        {
            List<int>? ids = HttpContext.Session.GetObject<List<int>>("cartKey");

            if (ids == null) return NotFound();

            ids.Remove(id);

            HttpContext.Session.SetObject("cartKey", ids);

            return RedirectToAction("Index", "Home");
        }
    }
}
