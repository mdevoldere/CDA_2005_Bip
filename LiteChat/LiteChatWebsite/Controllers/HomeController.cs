using Microsoft.AspNetCore.Mvc;

namespace LiteChatWebsite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
