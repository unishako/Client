using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private readonly IHomeService _service;
    
    public HomeController(ILogger<HomeController> logger, IHomeService service)
    {
        _logger = logger;
        _service = service;
    }

    public IActionResult Index()
    {
        Console.WriteLine(_service.Add(1,2));
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
    }
}