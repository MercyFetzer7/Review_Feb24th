using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Review.Models;

namespace Review.Controllers;

public class HomeController : Controller
{
    private MusicDbContext _musicDbContext;
    
    public HomeController(MusicDbContext temp)
    {
        _musicDbContext = temp;
    }
    
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult ArtistList()
    {
        var whatevs = _musicDbContext.Artists.ToList();
        return View(whatevs);
        
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