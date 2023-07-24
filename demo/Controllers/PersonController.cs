using demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace demo.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Person ps)
        {
            string message = ps.Fullname +  "-" + ps.ID + "-" +ps.BirthDay;
            ViewBag.thongBao = message;
            return View();

        }
    }   
}