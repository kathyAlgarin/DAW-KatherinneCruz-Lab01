using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using KatherinneCruz.Lab01.Models;

namespace KatherinneCruz.Lab01.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.Nombre = "Katherinne Jeannette Cruz Algarin";
        ViewBag.Carrera = "Ingeniería en Desarrollo de Software";
        ViewBag.Asignatura = "Desarrollo Multiplataforma de Aplicaciones Web";

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
