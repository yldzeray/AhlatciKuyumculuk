using Microsoft.AspNetCore.Mvc;

namespace AhlatciKuyumculuk.Shop.UI.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        public IActionResult Create()
        {
            ViewBag.Header = "Kategori İşlemleri";
            ViewBag.Title = "Yeni Kategori Oluştur";
            return View();
        }

        public IActionResult List()
        {
            ViewBag.Header = "Kategori İşlemleri";
            ViewBag.Title = "Kategori Düzenle";
            return View();
        }


    }
}
