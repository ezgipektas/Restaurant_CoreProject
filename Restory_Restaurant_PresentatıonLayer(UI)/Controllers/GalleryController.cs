using Microsoft.AspNetCore.Mvc;
using Restory_Restaurant_BusinessLayer.Abstract;

namespace Restory_Restaurant_PresentatıonLayer_UI_.Controllers
{
    public class GalleryController : Controller
    {
        private readonly IGalleryService _galleryService;

        public GalleryController(IGalleryService galleryService)
        {
            _galleryService = galleryService;
        }

        public IActionResult Index()
        {
            var ımage = _galleryService.TGetList();
            return View(ımage);
        }
    }
}
