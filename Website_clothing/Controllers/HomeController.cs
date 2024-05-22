using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Website_clothing.Models;
using X.PagedList;

namespace Website_clothing.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Website_clothing_DbContext _context;

        public HomeController(ILogger<HomeController> logger, Website_clothing_DbContext context)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var lstSanPham = _context.SanPhams.AsNoTracking().OrderBy(sp => sp.Ten).ToList();

            return View(lstSanPham);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Products(int? page)
        {
            int pageSize = 6;
            int pageNumber = page == null || page < 0 ? 1 : page.Value;
            var lstSanPham = _context.SanPhams.AsNoTracking().OrderBy(sp => sp.Ten).ToList();
            PagedList<SanPham> plSanPham = new PagedList<SanPham>(lstSanPham, pageNumber, pageSize);

            return View(plSanPham);
        }

        public IActionResult SingleProduct()
        {
            return View();
        }

        public IActionResult Contact()
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
