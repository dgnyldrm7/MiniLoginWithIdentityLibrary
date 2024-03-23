using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MiniLoginWithIdentityLibrary.Models;

namespace MiniLoginWithIdentityLibrary.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

     
    }
}
