using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Website_clothing.IServices;
using Website_clothing.Models;
using Website_clothing.Models.Authentication;
using Website_clothing.ViewModels;
using X.PagedList;

namespace Website_clothing.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly Website_clothing_DbContext _context;
		private readonly ISanPhamService _sanPhamService;
		private readonly IHangService _hangService;

		public HomeController(ILogger<HomeController> logger, Website_clothing_DbContext context, ISanPhamService sanPhamService, IHangService hangService)
		{
			_logger = logger;
			_context = context;
			_sanPhamService = sanPhamService;
			_hangService = hangService;
		}

		[Authentication]
		public async Task<IActionResult> Index()
		{
			var lstSanPham = await _sanPhamService.ListSanPhamOrderByName();

			return View(lstSanPham);
		}

		public IActionResult About()
		{
			return View();
		}

		public async Task<IActionResult> Products(int? page)
		{
			int pageSize = 6;
			int pageNumber = page == null || page < 0 ? 1 : page.Value;
			var lstSanPham = await _sanPhamService.ListSanPhamOrderByName();
			PagedList<SanPham> plSanPham = new PagedList<SanPham>(lstSanPham, pageNumber, pageSize);

			return View(plSanPham);
		}

		public async Task<IActionResult> SingleProduct(Guid id)
		{
			var sanPham = await _sanPhamService.GetById(id);
			var cTSanPham = _context.CtSanPhams.Where(ctsp => ctsp.IDSanPham == id).ToList();
			var mauSac = _context.mauSacs.ToList();
			var kichCo = _context.KichCos.ToList();
			var chatLieu = _context.chatlieus.ToList();
			var hang = _context.Hangs.ToList();

			var singleProductViewmodel = new SingleProductViewModel
			{
				sanPham = sanPham,
				cTSanPham = cTSanPham,
				MauSacs = mauSac,
				KichCos = kichCo,
				ChatLieus = chatLieu,
				hangs = hang
			};
			return View(singleProductViewmodel);
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
