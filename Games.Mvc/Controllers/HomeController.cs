using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Games.Mvc.Models;
using Microsoft.AspNetCore.Authorization;
using Games.Mvc.Data;

namespace Games.Mvc.Controllers;

[Authorize]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDbContext _database;

    public HomeController(ILogger<HomeController> logger, AppDbContext database)
    {
        _logger = logger;
        _database = database;
    }

    public IActionResult Index()
    {
        var games = _database.Games.ToList();

        return View(games);
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
