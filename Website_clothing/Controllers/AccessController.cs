using Microsoft.AspNetCore.Mvc;
using Website_clothing.Models;
using Website_clothing.ViewModels;

namespace Website_clothing.Controllers
{
	public class AccessController : Controller
	{
		private readonly Website_clothing_DbContext _context;

		public AccessController(Website_clothing_DbContext context)
		{
			_context = context;
		}

		[HttpGet]
		public IActionResult Login()
		{
			if (HttpContext.Session.GetString("Email") == null)
			{
				return View();
			}
			else
			{
				return RedirectToAction("Index", "Home");
			}
		}

		[HttpPost]
		public IActionResult Login(KhachHang khachHang, NhanVien nhanVien)
		{
			if (HttpContext.Session.GetString("Email") == null)
			{
				var kh = _context.KhachHangs.Where(k => k.Email.Equals(khachHang.Email) && k.MatKhau.Equals(khachHang.MatKhau)).FirstOrDefault();
				var nv = _context.NhanViens.Where(n => n.Email.Equals(nhanVien.Email) && n.MatKhau.Equals(nhanVien.MatKhau)).FirstOrDefault();
				var loginViewModel = new LoginViewModel
				{
					KhachHang = kh,
					nhanVien = nv
				};
				if (kh != null)
				{
					HttpContext.Session.SetString("Email", kh.Email.ToString());
					return RedirectToAction("Index", "Home");
				}
				else if (nv != null)
				{
					HttpContext.Session.SetString("Email", nv.Email.ToString());
					return RedirectToAction("Index", "HomeAdmin");
				}
			}
			return View();
		}

		[HttpPost]
		public IActionResult Login(string email, string password)
		{

			return View();
		}

		public IActionResult Logout()
		{
			HttpContext.Session.Clear();
			HttpContext.Session.Remove("Email");
			return RedirectToAction("Login", "Access");
		}
	}
}
