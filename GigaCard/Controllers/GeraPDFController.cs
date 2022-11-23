using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GigaCard.Models;
using Rotativa.AspNetCore;



namespace AspCore_PDF.Controllers;

public class GeraPDFController : Controller
{
    public IActionResult VisualizarComoPDF() => new ViewAsPdf("Card");
}