using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(int number )
        {
            int BinhPhuong = number * number ; 
            ViewBag.thongBao = "Binh phuong cua so :  " +number + "la : " + BinhPhuong; 
            return View();
        }
    }
}