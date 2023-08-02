using Microsoft.AspNetCore.Mvc;

namespace checkpoint.Controllers
{
    public class DashBoardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
