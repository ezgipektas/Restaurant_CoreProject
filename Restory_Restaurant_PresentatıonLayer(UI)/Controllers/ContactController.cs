using Microsoft.AspNetCore.Mvc;
using Restory_Restaurant_BusinessLayer.Abstract;

namespace Restory_Restaurant_PresentatıonLayer_UI_.Controllers
{
    public class ContactController : Controller
    {
       private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            var i=_contactService.TGetList();
            return View(i);
        }
    }
}
