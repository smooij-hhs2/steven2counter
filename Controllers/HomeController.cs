using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using steven2counter.Models;

namespace steven2counter.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private static int counter = 0;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
	counter += 1;
        return View(counter);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
