using FrontToBackp2.DAL;
using FrontToBackp2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FrontToBackp2.Controllers
{
    public class HomeController : Controller
    {
        AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Product> products = 
                await _context.Products
                 .Include(x => x.Images)
                 .ToListAsync();

            return View(products);
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if(id == null)
            {
                return BadRequest();
            }
            Product product = await _context.Products
                .Include(x => x.Images)
                .Include(x => x.Category)
                .FirstOrDefaultAsync(P=>P.Id==id);
            return View(product);
        }
    }
}
