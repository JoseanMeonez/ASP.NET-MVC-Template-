using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers;

public class HomeController : Controller
{
	private readonly ILogger<HomeController> _logger;

	public HomeController(ILogger<HomeController> logger)
	{
		_logger = logger;
	}

	public IActionResult Index()
	{
		// if (HttpContext.Session.GetString("value") == null)
		// {
		// 	return RedirectToAction("Login", "Home");
		// }

		ViewData["Title"] = "Menú";
		ViewData["Desc"] = "Menú Principal";
		ViewData["Icon"] = "fa-solid fa-house-chimney";
		ViewData["Breadcrumb"] = "Inicio";
		return View();
	}

	public IActionResult Login()
	{
		return View();
	}

	[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
	public IActionResult Error()
	{
		return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
	}
}
