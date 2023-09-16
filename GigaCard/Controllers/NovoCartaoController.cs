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

public class NovoCartaoController : Controller
{
    private readonly ILogger<NovoCartaoController> _logger;

    public NovoCartaoController(ILogger<NovoCartaoController> logger)
    {
        _logger = logger;
    }

    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
