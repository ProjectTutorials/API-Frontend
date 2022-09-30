using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ApiFrontend.Models;

namespace ApiFrontend.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
