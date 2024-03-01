using Microsoft.AspNetCore.Mvc;

namespace PRELIM_E3_Assignment_ARNALDO_BSIT32E1.Controllers
{
    public class HomePage : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
