using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GigaCard.Models;

namespace GigaCard.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Card()
    {
        return View();
    }

    public IActionResult Cartoes()
    {
        return View();
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult NovoCartao()
    {
        return View();
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
