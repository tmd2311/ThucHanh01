using Bai1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Bai1.Controllers
{
    public class HomeController : Controller
    {
        QlthuVienContext db= new QlthuVienContext();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<TSach> sach= db.TSaches.ToList();
            return View(sach);
        }

        public IActionResult SachTheoLoai(string maNgonNgu)
        {
            List<TSach> sach= db.TSaches.AsNoTracking().Where(x=>x.MaNgonNgu==maNgonNgu).ToList();
            return View(sach);
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
