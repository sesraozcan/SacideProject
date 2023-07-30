using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace SacideProject.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}