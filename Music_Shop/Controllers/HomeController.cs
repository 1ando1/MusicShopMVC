using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Music_Shop.Helpers;
using Music_Shop.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Music_Shop.Controllers
{
    public class HomeController : Controller
    {
        private readonly MusicShopDbContext context;

        public HomeController(MusicShopDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var guitars = context.Guitars.Select(g => new Music_Shop.ViewModels.GuitarCardViewModel()
            {
                Guitar = g,
            }).ToList();

            foreach (var item in guitars)
            {
                item.IsInCard = IsProductInCart(item.Guitar.Id);
            }

            return View(guitars);
        }

        private bool IsProductInCart(int id)
        {
            List<int>? ids = HttpContext.Session.GetObject<List<int>>("cartKey");
            if (ids == null) return false;

            return ids.Contains(id);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
