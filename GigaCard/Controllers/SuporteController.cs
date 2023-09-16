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

public class SuporteController : Controller
{
    private readonly ILogger<SuporteController> _logger;

    public SuporteController(ILogger<SuporteController> logger)
    {
        _logger = logger;
    }

    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
