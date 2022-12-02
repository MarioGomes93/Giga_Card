using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GigaCard.Models;
using Microsoft.AspNetCore.Http;

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

    public IActionResult Remodelar()
    {
        return View();
    }

    [HttpPost("FileUpload")]

    public async Task<IActionResult> Index(List<IFormFile> files)
    {
        var size = files.Sum(h => h.Length);
        var filePaths = new List<string>();
        foreach (var formFile in files)
        {
            if(formFile.Length > 0)
            {
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), formFile.FileName);
                filePaths.Add(filePath);
                using (var stream=new FileStream(filePath, FileMode.Create))
                {
                    await formFile.CopyToAsync(stream);
                } 
                
            }
        }
        return Ok(new { files.Count, size, filePaths });
    }

    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
