using Microsoft.AspNetCore.Mvc;
using PlanItUp.Data;
using PlanItUp.Models;
using PlanItUp.Models.ViewModels;
using System.Diagnostics;

namespace PlanItUp.Controllers
{
    public class HomeController : BaseController
    {

        public IActionResult Index()
    {
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
}