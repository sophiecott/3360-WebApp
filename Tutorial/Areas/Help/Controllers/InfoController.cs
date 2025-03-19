using Microsoft.AspNetCore.Mvc;

namespace Tutorial.Areas.Help.Controllers
{
    [Area("Help")]
    public class InfoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
