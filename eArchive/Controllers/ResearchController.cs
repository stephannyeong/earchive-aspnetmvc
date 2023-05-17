using eArchive.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eArchive.Controllers
{
    public class ResearchController : Controller
    {
        private readonly AppDbContext _context;

        public ResearchController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Researches.ToListAsync());
        }
    }
}
