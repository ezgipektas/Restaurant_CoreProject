using Microsoft.AspNetCore.Mvc;

namespace Restory_Restaurant_PresentatıonLayer_UI_.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult AboutUs()
        {
            return PartialView();
        }
    }
}
