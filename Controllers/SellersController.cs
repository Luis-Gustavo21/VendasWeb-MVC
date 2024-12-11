using Microsoft.AspNetCore.Mvc;

namespace VendasWeb_MVC.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}