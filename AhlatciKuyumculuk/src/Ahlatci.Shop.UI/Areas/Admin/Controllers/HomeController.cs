using Microsoft.AspNetCore.Mvc;

namespace AhlatciKuyumculuk.Shop.UI.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Header = "Ahlatçı Shop";
            ViewBag.Title = "Yönetim Paneli";
            return View();
        }
    }
}
