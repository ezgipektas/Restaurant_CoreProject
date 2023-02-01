using Microsoft.AspNetCore.Mvc;

namespace Restory_Restaurant_PresentatıonLayer_UI_.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult QRCode()
        {
            return View();
        }
    }
}
