using AppBay.DAL;
using AppBay.Models;
using AppBay.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppBay.ViewComponents
{
    public class FooterViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;

        public FooterViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
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
