using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TrainingApp.Entities.Data;
using TrainingApp.Models;

namespace TrainingApp.Areas.User.Controllers
{
    [Area("User")]
    public class AuthController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AuthController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Registration()
        {
            return View();
        }














        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}