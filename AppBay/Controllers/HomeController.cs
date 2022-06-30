using AppBay.DAL;
using AppBay.Models;
using AppBay.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppBay.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            HomeVM model = new HomeVM
            {
                Settings = await _context.Settings.FirstOrDefaultAsync(),
                SocialMedias = await _context.SocialMedias.ToListAsync(),
            };
            return View(model);
        }
    }
}
