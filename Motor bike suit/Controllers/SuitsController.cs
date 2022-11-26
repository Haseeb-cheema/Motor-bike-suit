using Microsoft.AspNetCore.Mvc;

namespace Motor_bike_suit.Controllers
{
    public class SuitsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
