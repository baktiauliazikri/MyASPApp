using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyASPApp.Models;

namespace MyASPApp.Controllers;

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

    public IActionResult Hello()
    {
        return Content("Hello ASP.NET Core Class");
    }

    public IActionResult Trainer()
    {
        string trainer1 = "Bakti Aulia Zikri";
        string trainer2 = "Maisan Nabil Zuhdi";

        List<string> lstTrainer = new List<string>{
            "Bakti Aulia Zikri", "Maisan Nabil Zuhdi", "John", "Bob"
        };

        ViewData["trainer1"] = trainer1;
        ViewData["trainer2"] = trainer2;
        ViewData["lstTrainer"] = lstTrainer;

        ViewBag.Course = "ASP.NET Core";

        ViewBag.Courses = new List<string>{
            "ASP.NET Core 6", ".NET Microservices","Azure DevOps","Power Automate","Power Apps"
        };
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
