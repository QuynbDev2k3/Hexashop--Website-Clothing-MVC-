using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
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

		public IActionResult Login()
		{
			ClaimsPrincipal claimsUser = HttpContext.User;
			if (claimsUser.Identity.IsAuthenticated)
			{
				return RedirectToAction("Index", "Home");
			}
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Login(LoginViewModel loginVM)
		{
			if (_context.KhachHangs.Any(kh => kh.Email == loginVM.Email && kh.MatKhau == loginVM.MatKhau) || _context.NhanViens.Any(nv => nv.Email == loginVM.Email && nv.MatKhau == loginVM.MatKhau))
			{
				List<Claim> claims = new List<Claim>()
				{
					new Claim(ClaimTypes.NameIdentifier, loginVM.Email),
					new Claim("OtherProperties", "Example Role")
				};
				ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
				AuthenticationProperties properties = new AuthenticationProperties()
				{
					AllowRefresh = true,
					IsPersistent = loginVM.KeepLoggedIn,
				};
				await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), properties);

				return RedirectToAction("Index", "Home");
			}

			ViewData["ValidateMessage"] = "Login Fail";
			return View();
		}
	}
}
