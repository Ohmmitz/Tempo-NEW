using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TEMPO.Models;

namespace TEMPO.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]

    public IActionResult index(LoginData abc)
    {
        if (ModelState.IsValid)
        {
            return View("success", abc);
        }
        return View(abc);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Register()
    {
        return View();
    }
    [HttpPost]

    public IActionResult Register(LoginData abc)
    {
        if (ModelState.IsValid)
        {
            return View("success", abc);
        }
        return View(abc);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

