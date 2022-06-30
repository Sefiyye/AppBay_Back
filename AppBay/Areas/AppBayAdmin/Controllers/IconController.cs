using AppBay.DAL;
using AppBay.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppBay.Areas.AppBayAdmin.Controllers
{
    [Area("AppBayAdmin")]
    public class IconController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public IconController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<Icon> icon = await _context.Icons.ToListAsync();
            return View(icon);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(Icon icon)
        {
            if (!ModelState.IsValid) return View();
            await _context.AddAsync(icon);
            await _context.SaveChangesAsync();
            return RedirectToAction("Icon", "Index");
        }
        public async Task<IActionResult> Detail(int id)
        {
            Icon icon = await _context.Icons.FirstOrDefaultAsync(i => i.Id == id);
            return View(icon);
        }
        public async Task<IActionResult> Delete(int id)
        {
            Icon icon = await _context.Icons.FirstOrDefaultAsync(i => i.Id == id);
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteIcon(int id)
        {
            Icon existedIcon = await _context.Icons.FirstOrDefaultAsync(i => i.Id == id);
            if (existedIcon == null) return NotFound();
            _context.Icons.Remove(existedIcon);
            await _context.SaveChangesAsync();
            return RedirectToAction("Icon", "Index");
        }
        public async Task<IActionResult> Edit(int id)
        {
            Icon icon = await _context.Icons.FirstOrDefaultAsync(i => i.Id == id);
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(int id, Icon icon)
        {
            Icon existedIcon = await _context.Icons.FirstOrDefaultAsync(i => i.Id == id);
            if (!ModelState.IsValid) return View();
            //if (existedIcon == null) return NotFound();
            await _context.AddAsync(existedIcon);
            await _context.SaveChangesAsync();
            return RedirectToAction("Icon", "Index");



        }
    }
}
